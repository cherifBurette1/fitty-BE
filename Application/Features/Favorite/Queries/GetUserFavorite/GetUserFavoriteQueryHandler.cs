using Application.Contracts.Repos;
using Application.Response;
using Domain.Entities;
using MediatR;

namespace Application.Features.Favorite.Queries.GetUserFavorite
{
    public class GetUserFavoriteCommandHandler : IRequestHandler<GetUserFavoriteQuery, ApiResponse<List<GetUserFavoriteQueryResponse>>>
    {
        private readonly IFavoriteRepo _favoriteRepo;
        public GetUserFavoriteCommandHandler(IFavoriteRepo favoriteRepo)
        {
            _favoriteRepo = favoriteRepo;
        }

        public async Task<ApiResponse<List<GetUserFavoriteQueryResponse>>> Handle(GetUserFavoriteQuery request, CancellationToken cancellationToken)
        {
            var response = await _favoriteRepo.GetUserFavorite(request.UserId) ;

            return ApiResponse<List<GetUserFavoriteQueryResponse>>
                .GetSuccessApiResponse(response);


        }
    }
}
