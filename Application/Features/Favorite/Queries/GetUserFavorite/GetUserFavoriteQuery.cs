using Application.Response;
using MediatR;

namespace Application.Features.Favorite.Queries.GetUserFavorite
{
    public class GetUserFavoriteQuery : IRequest<ApiResponse<List<GetUserFavoriteQueryResponse>>>
    {
        public Guid UserId { get; set; }
    }
}