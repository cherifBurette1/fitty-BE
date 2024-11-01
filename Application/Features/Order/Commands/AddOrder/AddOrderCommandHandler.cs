using Application.Contracts.Identity;
using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Order.Commands.AddOrder
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, ApiResponse<AddOrderCommandResponse>>
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ICartRepo _cartRepo;
        private readonly IClaimService _claimService;
        private readonly IDishRepo _dishRepo;
        public AddOrderCommandHandler(IOrderRepo orderRepo, ICartRepo cartRepo, IClaimService claimService, IDishRepo dishRepo)
        {
            _orderRepo = orderRepo;
            _cartRepo = cartRepo;
            _claimService = claimService;
            _dishRepo = dishRepo;
        }

        public async Task<ApiResponse<AddOrderCommandResponse>> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            List<Dish> dishes = await _dishRepo.GetDishesByIds(request.CartItemIds);
            if (!dishes.Any() || dishes.Count != request.CartItemIds.Count)
                return ApiResponse<AddOrderCommandResponse>.GetBadRequestApiResponse("Invalid Dishes Ids");


            Domain.Entities.Order order = new Domain.Entities.Order
            {
                CookingInstructions = request.CookingInstructions,
                DeliveryInstructions = request.DeliveryInstructions,
                OrderDate = DateTime.UtcNow,
                OrderStatus = "Delivered",
                LocationId = request.LocationId,
                PaymentOptionId = request.PaymentId,
                TotalPrice = request.TotalPrice,
                PromoCode = request.PromoCode,
                ShippingProviderId = request.ShippingId,
                Dishes = dishes
            };
            await _orderRepo.AddAsync(order);

            var userId = _claimService.GetUserId();

             await _cartRepo.RemoveCartItems(Guid.Parse(userId));

            return ApiResponse<AddOrderCommandResponse>
                .GetSuccessApiResponse(new AddOrderCommandResponse { IsSuccess = true });


        }
    }
}
