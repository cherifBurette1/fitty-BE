using Application.Response;
using MediatR;

namespace Application.Features.Cart.Commands.AddCartItem
{
    public class AddCartItemCommand : IRequest<ApiResponse<AddCartItemCommandResponse>>
    {
        public Guid UserId { get; set; }
        public Guid DishId { get; set; }
        public int Quantity { get; set; }
    }
}