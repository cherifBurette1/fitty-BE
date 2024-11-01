using Application.Contracts.Repos;
using Application.Features.Cart.Queries.GetCartItems;
using Application.Features.Cart.Queries.GetShippingProviders;
using Application.Features.Cart.Queries.GetUserLocations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Implementation.Repos
{
    internal class CartRepo : BaseRepo<CartItem>, ICartRepo
    {
        public CartRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<List<GetShippingProviderQueryResponse>> GetShippingProviders()
        {
            return await _context.ShippingProviders.Select(x => new GetShippingProviderQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
            }).ToListAsync();
        }
        public async Task<List<GetPaymentOptionsQueryResponse>> GetPaymentOptions()
        {
            return await _context.PaymentOptions.Select(x => new GetPaymentOptionsQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
                isActive = !x.IsDeleted,
            }).ToListAsync();
        }
        public async Task<List<GetUserLocationsQueryResponse>> GetUserAddress(Guid userId)
        {
            return await _context.Locations.Where(x => x.ClientId == userId).Select(x => new GetUserLocationsQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
        }
        public async Task<CartItem> IsExistingCartItem(Guid userId, Guid dishId)
        {
            return await _context.CartItems.Where(x => x.ClientId == userId && x.DishId == dishId).FirstOrDefaultAsync();
        }
        public async Task<List<GetCartItemsQueryResponse>> GetCartItemList(Guid userId)
        {
            return await _context.CartItems.Where(x => x.ClientId == userId).Select(x => new GetCartItemsQueryResponse { Id = x.DishId, Description = x.Dish.Description, Name = x.Dish.Name, ImageURL = x.Dish.ImageURL, Price = x.Dish.Price, Quantity = x.Quantity }).ToListAsync();
        }
        public async Task RemoveCartItems(Guid userId)
        {
            var cartItems = await _context.CartItems.Where(x => x.ClientId == userId).ToListAsync();
            if (cartItems.Any())
            {
                _context.RemoveRange(cartItems);
                await _context.SaveChangesAsync();
            }

        }
    }
}