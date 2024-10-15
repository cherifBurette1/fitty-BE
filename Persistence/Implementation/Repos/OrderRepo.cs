using Application.Contracts.Repos;
using Application.Features.Order.Queries.GetUserOrders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Implementation.Repos
{
    internal class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(AppDbContext context) : base(context)
        {
        }
        public async Task<List<GetUserOrdersQueryResponse>> GetUsersOrders(Guid userId)
        {
            return await _context.Orders.Select(o => new GetUserOrdersQueryResponse
            {
                CookingInstructions = o.CookingInstructions,
                PaymentName = o.PaymentOption.Name,
                TotalPrice = o.TotalPrice,
                DeliveryInstructions = o.DeliveryInstructions,
                LocationName = o.Location.Name,
                ShippingName = o.ShippingProvider.Name,
                Status = "Delivered",
                Date = o.OrderDate.ToShortDateString(),
                Id = userId
            }).ToListAsync();
        }
    }
}