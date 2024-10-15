using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cart.Commands.AddCartItem
{
    public class AddCartItemCommandHandler : IRequestHandler<AddCartItemCommand, ApiResponse<AddCartItemCommandResponse>>
    {
        private readonly ICartRepo _cartRepo;
        public AddCartItemCommandHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<AddCartItemCommandResponse>> Handle(AddCartItemCommand request, CancellationToken cancellationToken)
        {
            CartItem cartItem;
            cartItem = await _cartRepo.IsExistingCartItem(request.UserId, request.DishId);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    Id = new Guid(),
                    ClientId = request.UserId,
                    Quantity = request.Quantity,
                    DishId = request.DishId
                };
            await _cartRepo.AddAsync(cartItem);
            }
            else
            {
                cartItem.Quantity = request.Quantity;
                await _cartRepo.UpdateAsync(cartItem);
            }

            return ApiResponse<AddCartItemCommandResponse>
                .GetSuccessApiResponse(new AddCartItemCommandResponse { IsSuccess = true });


        }
    }
}
