using API.Attributes;
using Application.Features.Order.Commands.AddOrder;
using Application.Features.Order.Queries.GetUserOrders;
using Identity.Enums;
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
        [AuthorizeRoles(UserRolesEnum.Client)]
        [HttpPost("AddOrder")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<AddOrderCommandResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetShippingOptions([FromBody] AddOrderCommand body)
        {
            var result = await _mediator.Send(body);

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Client)]
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
