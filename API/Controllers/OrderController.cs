using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Cart.Commands.AddCartItem;
using Application.Features.Cart.Commands.RemoveCartItem;
using Application.Features.Cart.Queries.GetCartItems;
using Application.Features.Cart.Queries.GetShippingProviders;
using Application.Features.Cart.Queries.GetUserLocations;
using Application.Features.Order.Commands.AddOrder;
using Application.Features.Order.Queries.GetUserOrders;
using Application.Features.Reservations.Queries.GetAllDishes;
using Application.Features.Reservations.Queries.GetDish;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [AllowAnonymous]
        [HttpPost("AddOrder")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<AddOrderCommandResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetShippingOptions([FromBody] AddOrderCommand body)
        {
            var result = await _mediator.Send(body);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpGet("GetAllUsersOrders")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<GetUserOrdersQueryResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllUsersOrders([FromQuery] GetUserOrdersQuery body)
        {
            var result = await _mediator.Send(body);

            return GetApiResponse(result);
        }
    }
}
