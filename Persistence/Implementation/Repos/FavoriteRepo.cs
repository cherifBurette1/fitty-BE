using Application.Contracts.Repos;
using Application.Features.Favorite.Queries.GetUserFavorite;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Implementation.Repos
{
    internal class FavoriteRepo : BaseRepo<Favorite>, IFavoriteRepo
    {
        public FavoriteRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<bool> RemoveFromFavorite(Guid userId, Guid dishId)
        {
            var favorite = await _context.Favorites.Where(x => x.ClientId == userId && x.DishId == dishId).FirstAsync();
             _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> AddToFavorite(Guid userId, Guid dishId)
        {
            var favorite = await _context.Favorites.Where(x => x.ClientId == userId && x.DishId == dishId).FirstAsync();
            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<GetUserFavoriteQueryResponse>> GetUserFavorite(Guid userId)
        {
            return await _context.Favorites.Where(x => x.ClientId == userId).Select(x => new GetUserFavoriteQueryResponse
            {
                Id = x.Dish.Id,
                Name = x.Dish.Name,
                ImageURL = x.Dish.ImageURL,
                Price = x.Dish.Price,
                Rating = x.Dish.Rating,
            }).ToListAsync();
        }

    }
}
