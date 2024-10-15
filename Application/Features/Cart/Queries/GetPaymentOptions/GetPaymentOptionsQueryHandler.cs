using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cart.Queries.GetShippingProviders
{
    public class GetPaymentOptionsQueryHandler : IRequestHandler<GetPaymentOptionsQuery, ApiResponse<List<GetPaymentOptionsQueryResponse>>>
    {
        private readonly ICartRepo _cartRepo;
        public GetPaymentOptionsQueryHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<List<GetPaymentOptionsQueryResponse>>> Handle(GetPaymentOptionsQuery request, CancellationToken cancellationToken)
        {
            var response = await _cartRepo.GetPaymentOptions();

            return ApiResponse<List<GetPaymentOptionsQueryResponse>>
                .GetSuccessApiResponse(response);


        }
    }
}
