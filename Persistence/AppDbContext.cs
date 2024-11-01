using Application.Contracts.Identity;
using Domain.Common;
using Domain.Entities;
using Domain.LogEntities;
using Identity.Entities;
using Identity.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Configurations;
using System.Linq.Expressions;

namespace Persistence
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        private readonly IClaimService _claimService;

        public AppDbContext(DbContextOptions options, IClaimService? claimService = null) : base(options)
        {
            _claimService = claimService;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<DishComponent> DishComponents { get; set; }
        public DbSet<DishNutrient> DishNutrient { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }
        public DbSet<ShippingProvider> ShippingProviders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApiResponseLog> ApiResponseLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Ensure soft delete behavior for IAuditable entities
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(IAuditable), true).Length > 0)
                {
                    builder.Entity(entityType.Name).Property<bool>("IsDeleted");
                }

                var isActiveProperty = entityType.FindProperty("IsDeleted");
                if (isActiveProperty != null && isActiveProperty.ClrType == typeof(bool))
                {
                    var entityBuilder = builder.Entity(entityType.ClrType);
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var methodInfo = typeof(EF).GetMethod(nameof(EF.Property))!.MakeGenericMethod(typeof(bool))!;
                    var efPropertyCall = Expression.Call(null, methodInfo, parameter, Expression.Constant("IsDeleted"));
                    var body = Expression.MakeBinary(ExpressionType.Equal, efPropertyCall, Expression.Constant(false));
                    var expression = Expression.Lambda(body, parameter);
                    entityBuilder.HasQueryFilter(expression);
                }
            }

            // Seed initial data
            Seed(builder);

            // Add entity configurations
            AddEntitiesConfigurations(builder);

            // Call base OnModelCreating
            base.OnModelCreating(builder);
        }

        private void AddEntitiesConfigurations(ModelBuilder builder)
        {
            builder.AddApiResponseLogConfiguration();
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedCategories(modelBuilder);
            SeedPaymentOptions(modelBuilder);
            SeedShippingProviders(modelBuilder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "c920e9a4-f3e1-4f2c-ad8a-e2b297497dbd",
                    Name = nameof(UserRolesEnum.Admin),
                    NormalizedName = nameof(UserRolesEnum.Admin).ToUpper()
                },
                new IdentityRole
                {
                    Id = "4c2a2769-de49-4e00-b487-baa0c8e09cfa",
                    Name = nameof(UserRolesEnum.Client),
                    NormalizedName = nameof(UserRolesEnum.Client).ToUpper()
                }
            );
        }

        private void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d11"), Name = "Mediterranean Diet", Icon = "fa-solid fa-umbrella-beach" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d12"), Name = "Balanced Diet", Icon = "fa-solid fa-scale-balanced" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d13"), Name = "Low Carb Diet", Icon = "gluten-free-icon" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d14"), Name = "Vegetarian Diet", Icon = "fa-solid fa-clover" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d15"), Name = "Ketogenic Diet", Icon = "fa-solid fa-egg" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d16"), Name = "Vegan Diet", Icon = "fa-solid fa-plant-wilt" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d17"), Name = "Paleo Diet", Icon = "fa-solid fa-mountain" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d18"), Name = "Pescatarian Diet", Icon = "fa-solid fa-fish" },
                new Category { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d19"), Name = "Dukan Diet", Icon = "fa-solid fa-dna" }
            );
        }

        private void SeedPaymentOptions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentOption>().HasData(
                new PaymentOption { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d20"), Name = "Credit Card" },
                new PaymentOption { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d21"), Name = "Cash" }
            );
        }

        private void SeedShippingProviders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingProvider>().HasData(
                new ShippingProvider { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d22"), Name = "Marsool", Price = 100 },
                new ShippingProvider { Id = Guid.Parse("c920e9a4-f3e1-4f2c-ad8a-e2b297497d23"), Name = "Uber", Price = 100 }
            );
        }

        public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            foreach (var entry in ChangeTracker.Entries<IAuditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTimeOffset.UtcNow;
                        entry.Entity.CreatedBy = _claimService.GetUserId();
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTimeOffset.UtcNow;
                        entry.Entity.UpdatedBy = _claimService.GetUserId();
                        break;
                    case EntityState.Deleted:
                        entry.Entity.DeletedDate = DateTimeOffset.UtcNow;
                        entry.Entity.IsDeleted = true;
                        entry.Entity.DeletedBy = _claimService.GetUserId();
                        entry.State = EntityState.Modified;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}