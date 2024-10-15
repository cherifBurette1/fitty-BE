using Application.Response;
using MediatR;

namespace Application.Features.Cart.Queries.GetCartItems
{
    public class GetCartItemsQuery : IRequest<ApiResponse<List<GetCartItemsQueryResponse>>>
    {
        public Guid UserId {  get; set; }
    }
}