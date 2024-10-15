using Application.Response;
using MediatR;

namespace Application.Features.Order.Queries.GetUserOrders
{
    public class GetUserOrdersQuery : IRequest<ApiResponse<List<GetUserOrdersQueryResponse>>>
    {
        public Guid UserId { get; set; }
    }
}