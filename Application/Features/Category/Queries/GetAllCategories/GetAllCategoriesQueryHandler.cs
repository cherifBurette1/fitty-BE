using Application.Contracts.Repos;
using Application.Response;
using AutoMapper;
using MediatR;

namespace Application.Features.Category.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, ApiResponse<List<GetAllCategoriesQueryResponse>>>
    {
        private readonly IDishRepo _dishRepo;
        public GetAllCategoriesQueryHandler(IDishRepo dishRepo, IMapper mapper)
        {
            _dishRepo = dishRepo;
        }

        public async Task<ApiResponse<List<GetAllCategoriesQueryResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _dishRepo.GetAllCategories();

            return ApiResponse<List<GetAllCategoriesQueryResponse>>.GetSuccessApiResponse(categories);
        }
    }
}
