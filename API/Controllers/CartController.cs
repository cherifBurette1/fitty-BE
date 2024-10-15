using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Cart.Commands.AddCartItem;
using Application.Features.Cart.Commands.RemoveCartItem;
using Application.Features.Cart.Queries.GetCartItems;
using Application.Features.Cart.Queries.GetShippingProviders;
using Application.Features.Cart.Queries.GetUserLocations;
using Application.Features.Reservations.Queries.GetAllDishes;
using Application.Features.Reservations.Queries.GetDish;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CartController : BaseController
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [AllowAnonymous]
        [HttpGet("GetShippingProviders")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetShippingProviderQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetShippingOptions()
        {
            var result = await _mediator.Send(new GetShippingProviderQuery());

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpGet("GetPaymentOptions")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetPaymentOptionsQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetPaymentOptions()
        {
            var result = await _mediator.Send(new GetPaymentOptionsQuery());

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpGet("GetUserLocations")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetUserLocationsQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetUserLocations([FromQuery] GetUserLocationsQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpPost("AddCartItem")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(AddCartItemCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> AddCartItem([FromBody] AddCartItemCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpPost("RemoveCartItem")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(RemoveCartItemCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveCartItem([FromBody] RemoveCartItemCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpGet("GetAllCartItems")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetCartItemsQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveCartItem([FromQuery] GetCartItemsQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
    }
}
