using Application.Features.Order.Queries.GetUserOrders;
using Domain.Entities;

namespace Application.Contracts.Repos
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        Task<List<GetUserOrdersQueryResponse>> GetUsersOrders(Guid userId);
    }
}
