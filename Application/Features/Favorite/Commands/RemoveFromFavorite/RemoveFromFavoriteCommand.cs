using Application.Response;
using MediatR;

namespace Application.Features.Favorite.Commands.RemoveFromFavorite
{
    public class RemoveFromFavoriteCommand : IRequest<ApiResponse<RemoveFromFavoriteCommandResponse>>
    {
        public Guid UserId { get; set; }
        public Guid DishId { get; set; }
    }
}