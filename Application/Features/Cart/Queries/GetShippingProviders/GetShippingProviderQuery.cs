using Application.Response;
using MediatR;

namespace Application.Features.Cart.Queries.GetShippingProviders
{
    public class GetShippingProviderQuery : IRequest<ApiResponse<List<GetShippingProviderQueryResponse>>>
    {
    }
}