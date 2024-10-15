using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Favorite.Commands.RemoveFromFavorite

{
    public class CreateBrandCommandHandler : IRequestHandler<RemoveFromFavoriteCommand, ApiResponse<RemoveFromFavoriteCommandResponse>>
    {
        private readonly IFavoriteRepo _favoriteRepo;
        public CreateBrandCommandHandler(IFavoriteRepo favoriteRepo)
        {
            _favoriteRepo = favoriteRepo;
        }

        public async Task<ApiResponse<RemoveFromFavoriteCommandResponse>> Handle(RemoveFromFavoriteCommand request, CancellationToken cancellationToken)
        {
            var isDeleted = await _favoriteRepo.RemoveFromFavorite(request.UserId, request.DishId) ;

            return ApiResponse<RemoveFromFavoriteCommandResponse>
                .GetSuccessApiResponse(new RemoveFromFavoriteCommandResponse
                {
                    IsSuccess = isDeleted,
                });

        }
    }
}
