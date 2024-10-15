using Application.Features.Favorite.Queries.GetUserFavorite;
using Domain.Entities;

namespace Application.Contracts.Repos
{
    public interface IFavoriteRepo : IBaseRepo<Favorite>
    {
        Task<List<GetUserFavoriteQueryResponse>> GetUserFavorite(Guid userId);
        Task<bool> RemoveFromFavorite(Guid userId, Guid dishId);
    }
}
