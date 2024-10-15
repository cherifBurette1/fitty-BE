using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Order.Commands.AddOrder
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, ApiResponse<AddOrderCommandResponse>>
    {
        private readonly IOrderRepo _orderRepo;
        public AddOrderCommandHandler(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<ApiResponse<AddOrderCommandResponse>> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Order order = new Domain.Entities.Order
            {
                CookingInstructions = request.CookingInstructions,
                DeliveryInstructions = request.DeliveryInstructions,
                OrderDate= DateTime.UtcNow,
                OrderStatus = "Delivered",
                LocationId = request.LocationId,
                PaymentOptionId = request.PaymentId,
                TotalPrice = request.TotalPrice,
                PromoCode = request.PromoCode,
                ShippingProviderId = request.ShippingId,
            };
            {

            }
                await _orderRepo.AddAsync(order);
            return ApiResponse<AddOrderCommandResponse>
                .GetSuccessApiResponse(new AddOrderCommandResponse { IsSuccess = true });


        }
    }
}
