using Application.Response;
using MediatR;

namespace Application.Features.Cart.Queries.GetShippingProviders
{
    public class GetPaymentOptionsQuery : IRequest<ApiResponse<List<GetPaymentOptionsQueryResponse>>>
    {
    }
}