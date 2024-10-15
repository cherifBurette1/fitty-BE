using Application.Contracts.Repos;
using Application.Response;
using MediatR;

namespace Application.Features.Cart.Queries.GetUserLocations
{
    public class GetUserLocationsQueryHandler : IRequestHandler<GetUserLocationsQuery, ApiResponse<List<GetUserLocationsQueryResponse>>>
    {
        private readonly ICartRepo _cartRepo;
        public GetUserLocationsQueryHandler(ICartRepo cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<ApiResponse<List<GetUserLocationsQueryResponse>>> Handle(GetUserLocationsQuery request, CancellationToken cancellationToken)
        {
            var response = await _cartRepo.GetUserAddress(request.UserId);

            return ApiResponse<List<GetUserLocationsQueryResponse>>
                .GetSuccessApiResponse(response);


        }
    }
}
