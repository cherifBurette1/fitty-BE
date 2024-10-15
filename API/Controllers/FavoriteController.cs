using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Favorite.Commands.AddToFavorite;
using Application.Features.Favorite.Commands.RemoveFromFavorite;
using Application.Features.Favorite.Queries.GetUserFavorite;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FavoriteController : BaseController
    {
        private readonly IMediator _mediator;

        public FavoriteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [AllowAnonymous]
        [HttpGet("GetAllUserFavorite")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(GetUserFavoriteQueryResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetUserFavorite([FromQuery] GetUserFavoriteQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpPost("AddToFavorite")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(AddtoFavoriteCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> AddToFavorite([FromBody] AddtoFavoriteCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpPost("RemoveFromFavorite")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(RemoveFromFavoriteCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveFromFavorite([FromBody] RemoveFromFavoriteCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
    }
}
