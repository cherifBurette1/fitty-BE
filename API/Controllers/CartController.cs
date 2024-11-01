using API.Attributes;
using Application.Features.Cart.Commands.AddCartItem;
using Application.Features.Cart.Commands.RemoveCartItem;
using Application.Features.Cart.Queries.GetCartItems;
using Application.Features.Cart.Queries.GetShippingProviders;
using Application.Features.Cart.Queries.GetUserLocations;
using Identity.Enums;
using MediatR;
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
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpGet("GetShippingProviders")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetShippingProviderQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetShippingOptions()
        {
            var result = await _mediator.Send(new GetShippingProviderQuery());

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpGet("GetPaymentOptions")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetPaymentOptionsQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetPaymentOptions()
        {
            var result = await _mediator.Send(new GetPaymentOptionsQuery());

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpGet("GetUserLocations")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetUserLocationsQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetUserLocations([FromQuery] GetUserLocationsQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpPost("AddCartItem")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(AddCartItemCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> AddCartItem([FromBody] AddCartItemCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpPost("RemoveCartItem")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(RemoveCartItemCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> RemoveCartItem([FromBody] RemoveCartItemCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
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
