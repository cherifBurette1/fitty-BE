using Application.Response;
using MediatR;

namespace Application.Features.Cart.Queries.GetUserLocations
{
    public class GetUserLocationsQuery : IRequest<ApiResponse<List<GetUserLocationsQueryResponse>>>
    {
        public Guid UserId { get; set; }    
    }
}