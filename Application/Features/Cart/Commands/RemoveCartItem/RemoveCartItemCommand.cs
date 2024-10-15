using Application.Response;
using MediatR;

namespace Application.Features.Cart.Commands.RemoveCartItem
{
    public class RemoveCartItemCommand : IRequest<ApiResponse<RemoveCartItemCommandResponse>>
    {
        public Guid Id
        {
            get; set;
        }
    }
}