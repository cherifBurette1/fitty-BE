using Application.Contracts.Repos;
using Application.Response;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;
using Application.Features.Dishes.Queries.GetPaginatedDishes;

namespace Application.Features.Reservations.Queries.GetAllDishes
{
    public class GetAllDishesQueryHandler : IRequestHandler<GetAllDishesQuery, ApiResponse<PaginatedDishesResponse>>
    {
        private readonly IDishRepo _dishRepo;
        private readonly IMapper _mapper;

        public GetAllDishesQueryHandler(IDishRepo dishRepo, IMapper mapper)
        {
            _dishRepo = dishRepo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<PaginatedDishesResponse>> Handle(GetAllDishesQuery request, CancellationToken cancellationToken)
        {
            // Fetch paginated dishes and total count
            var (dishes, totalCount) = await _dishRepo.GetAllDishesPaginated(request.Page, request.PageSize);

            // Map the dishes to the response model
            var dishResponses = dishes.Select(a => new GetAllDishesQueryResponse
            {
                Id = a.Id,
                ImageURL = a.ImageURL,
                Price = a.Price,
                Rating = a.Rating,
                Name = a.Name
            }).ToList();

            // Calculate total pages
            var totalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize);

            // Create a paginated response
            var paginatedResponse = new PaginatedDishesResponse
            {
                Dishes = dishResponses,
                TotalPages = totalPages,
                CurrentPage = request.Page
            };

            return ApiResponse<PaginatedDishesResponse>.GetSuccessApiResponse(paginatedResponse);
        }
    }
}
