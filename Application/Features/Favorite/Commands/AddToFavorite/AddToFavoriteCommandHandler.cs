using Application.Contracts.Repos;
using Application.Response;
using MediatR;

namespace Application.Features.Favorite.Commands.AddToFavorite

{
    public class AddtoFavoriteCommandHandler : IRequestHandler<AddtoFavoriteCommand, ApiResponse<AddtoFavoriteCommandResponse>>
    {
        private readonly IFavoriteRepo _favoriteRepo;
        public AddtoFavoriteCommandHandler(IFavoriteRepo favoriteRepo)
        {
            _favoriteRepo = favoriteRepo;
        }

        public async Task<ApiResponse<AddtoFavoriteCommandResponse>> Handle(AddtoFavoriteCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Favorite favorite = new Domain.Entities.Favorite { Id = new Guid(), ClientId = request.UserId, DishId = request.DishId };
            var dishId = await _favoriteRepo.AddAsync(favorite);

            return ApiResponse<AddtoFavoriteCommandResponse>
                .GetSuccessApiResponse(new AddtoFavoriteCommandResponse
                {
                    IsSuccess = dishId != null ? true : false,
                });


        }
    }
}
