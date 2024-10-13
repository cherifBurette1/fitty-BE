using Application.Response;
using MediatR;

namespace Application.Features.Category.Queries.GetAllCategories
{
    public class GetAllCategoriesQuery : IRequest<ApiResponse<List<GetAllCategoriesQueryResponse>>>
    {
    }
}
