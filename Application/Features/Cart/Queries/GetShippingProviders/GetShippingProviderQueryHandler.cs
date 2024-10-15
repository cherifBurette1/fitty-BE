using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cart.Queries.GetShippingProviders
{
    public class GetShippingProviderQueryHandler : IRequestHandler<GetShippingProviderQuery, ApiResponse<List<GetShippingProviderQueryResponse>>>
    {
        private readonly ICartRepo _cartRepo;
        public GetShippingProviderQueryHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<List<GetShippingProviderQueryResponse>>> Handle(GetShippingProviderQuery request, CancellationToken cancellationToken)
        {
            var response = await _cartRepo.GetShippingProviders() ;

            return ApiResponse<List<GetShippingProviderQueryResponse>>
                .GetSuccessApiResponse(response);


        }
    }
}
