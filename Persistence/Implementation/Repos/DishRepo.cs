using Application.Contracts.Repos;
using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Category.Queries.GetAllCategories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Implementation.Repos
{
    internal class DishRepo : BaseRepo<Dish>, IDishRepo
    {
        public DishRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<(List<Dish> Dishes, int TotalCount)> GetAllDishesPaginated(int page, int pageSize)
        {
            var skip = (page - 1) * pageSize;

            // Get the total count of dishes
            var totalCount = await _context.Dishes.CountAsync();

            // Get the paginated dishes
            var dishes = await _context.Dishes
                .AsNoTracking()
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return (dishes, totalCount);
        }

        public async Task<Guid> AddDish(CreateDishCommand createDishCommand)
        {
            // Fetch categories associated with the dish
            List<Category> categories = await _context.Categories
                .Where(x => createDishCommand.Categories.Contains(x.Id))
                .ToListAsync();

            // Generate unique IDs for Dish and DishNutrient
            Guid dishId = Guid.NewGuid();

            // Add the dish
            var dish = new Dish
            {
                Id = dishId,
                Description = createDishCommand.Description,
                ImageURL = createDishCommand.ImageURL,
                Price = createDishCommand.Price,
                Rating = createDishCommand.Rating,
                Name = createDishCommand.Name,
                Categories = categories
            };

            await _context.Dishes.AddAsync(dish);

            // Add the dish nutrient
            Guid dishNutrientId = Guid.NewGuid();

            var dishNutrient = new DishNutrient
            {
                Id = dishNutrientId,
                Weight = createDishCommand.Weight,
                Calories = createDishCommand.Calories,
                Nature = createDishCommand.Nature,
                PreparationTime = createDishCommand.PreparationTime,
                DishId = dishId // Correct DishId reference
            };

            await _context.DishNutrient.AddAsync(dishNutrient);

            // Add dish components
            foreach (var component in createDishCommand.DishComponents)
            {
                Guid dishComponentId = Guid.NewGuid(); // Generate unique ID for each component
                var dishComponent = new DishComponent
                {
                    Id = dishComponentId,
                    DishId = dishId, // Link to the dish
                    Name = component
                };

                await _context.DishComponents.AddAsync(dishComponent);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            return dishId;
        }
        public async Task<List<GetAllCategoriesQueryResponse>> GetAllCategories()
        {
            return await _context.Categories.Select(x => new GetAllCategoriesQueryResponse { Id = x.Id, Name = x.Name, Icon = x.Icon }).ToListAsync();
        }
    }
}
