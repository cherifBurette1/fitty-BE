using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cart.Commands.RemoveCartItem
{
    public class RemoveCartItemCommandHandler : IRequestHandler<RemoveCartItemCommand, ApiResponse<RemoveCartItemCommandResponse>>
    {
        private readonly ICartRepo _cartRepo;
        public RemoveCartItemCommandHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<RemoveCartItemCommandResponse>> Handle(RemoveCartItemCommand request, CancellationToken cancellationToken)
        {
            CartItem cartItem = await _cartRepo.GetAsync(request.Id);
             await _cartRepo.DeleteAsync(cartItem);
            return ApiResponse<RemoveCartItemCommandResponse>
                .GetSuccessApiResponse(new RemoveCartItemCommandResponse { IsSuccess = true });


        }
    }
}
