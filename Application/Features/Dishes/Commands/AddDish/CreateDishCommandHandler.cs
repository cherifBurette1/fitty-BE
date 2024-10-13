using Application.Contracts.Repos;
using Application.Response;
using MediatR;

namespace Application.Features.Brands.Commands.CreateDish

{
    public class CreateBrandCommandHandler : IRequestHandler<CreateDishCommand, ApiResponse<CreateDishCommandResponse>>
    {
        private readonly IDishRepo _dishRepo;
        public CreateBrandCommandHandler(IDishRepo dishRepo)
        {
            _dishRepo = dishRepo;
        }

        public async Task<ApiResponse<CreateDishCommandResponse>> Handle(CreateDishCommand request, CancellationToken cancellationToken)
        {
            var dishId = await _dishRepo.AddDish(request);

            return ApiResponse<CreateDishCommandResponse>
                .GetSuccessApiResponse(new CreateDishCommandResponse
                {
                    Id = dishId
                });


        }
    }
}
