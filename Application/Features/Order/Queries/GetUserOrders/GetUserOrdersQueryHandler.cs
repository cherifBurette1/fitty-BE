using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Order.Queries.GetUserOrders
{
    public class GetUserOrdersQueryHandler : IRequestHandler<GetUserOrdersQuery, ApiResponse<List<GetUserOrdersQueryResponse>>>
    {
        private readonly IOrderRepo _orderRepo;
        public GetUserOrdersQueryHandler(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<ApiResponse<List<GetUserOrdersQueryResponse>>> Handle(GetUserOrdersQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderRepo.GetUsersOrders(request.UserId);
            return ApiResponse<List<GetUserOrdersQueryResponse>>
                .GetSuccessApiResponse( result);


        }
    }
}
