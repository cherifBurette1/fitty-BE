using Application.Response;
using MediatR;

namespace Application.Features.Favorite.Commands.AddToFavorite
{
    public class AddtoFavoriteCommand : IRequest<ApiResponse<AddtoFavoriteCommandResponse>>
    {
        public Guid UserId { get; set; }
        public Guid DishId { get; set; }
    }
}