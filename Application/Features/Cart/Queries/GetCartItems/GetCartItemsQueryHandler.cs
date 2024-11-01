    using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cart.Queries.GetCartItems
{
    public class GetCartItemsQueryHandler : IRequestHandler<GetCartItemsQuery, ApiResponse<List<GetCartItemsQueryResponse>>>
    {
        private readonly ICartRepo _cartRepo;
        public GetCartItemsQueryHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<List<GetCartItemsQueryResponse>>> Handle(GetCartItemsQuery request, CancellationToken cancellationToken)
        {
            var response = await _cartRepo.GetCartItemList(request.UserId) ;

            return ApiResponse<List<GetCartItemsQueryResponse>>
                .GetSuccessApiResponse(response);


        }
    }
}
