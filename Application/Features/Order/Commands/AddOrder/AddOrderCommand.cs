using Application.Response;
using MediatR;

namespace Application.Features.Order.Commands.AddOrder
{
    public class AddOrderCommand : IRequest<ApiResponse<AddOrderCommandResponse>>
    {
        public List<Guid> CartItemIds { get; set; }
        public Guid ShippingId { get; set; }
        public string CookingInstructions { get; set; }
        public string DeliveryInstructions { get; set; }
        public Guid PaymentId { get; set; }
        public Guid LocationId { get; set; }
        public int TotalPrice { get; set; }
        public string PromoCode { get; set; }
    }
}