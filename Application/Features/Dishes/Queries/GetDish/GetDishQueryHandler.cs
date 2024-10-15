using Application.Contracts.Repos;
using Application.Response;
using AutoMapper;
using MediatR;

namespace Application.Features.Reservations.Queries.GetDish
{
    public class GetDishQueryHandler : IRequestHandler<GetDishQuery, ApiResponse<GetDishQueryResponse>>
    {
        private readonly IDishRepo _dishRepo;
        private readonly IMapper _mapper;

        public GetDishQueryHandler(IDishRepo dishRepo, IMapper mapper)
        {
            _dishRepo = dishRepo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<GetDishQueryResponse>> Handle(GetDishQuery request, CancellationToken cancellationToken)
        {
            // Fetch paginated dishes and total count
            var dish = await _dishRepo.GetDish(request.Id);

            return ApiResponse<GetDishQueryResponse>.GetSuccessApiResponse(dish);
        }
    }
}
