using API.Attributes;
using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Reservations.Queries.GetAllDishes;
using Application.Features.Reservations.Queries.GetDish;
using Identity.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DishController : BaseController
    {
        private readonly IMediator _mediator;

        public DishController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet("GetAllDishes")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(PaginatedDishesResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllReservations([FromQuery] GetAllDishesQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AuthorizeRoles(UserRolesEnum.Admin)]
        [HttpPost("AddDish")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(CreateDishCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> AddDish([FromBody] CreateDishCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
        [AllowAnonymous]
        [HttpGet("GetDish")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(GetDishQueryResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetDish([FromQuery] GetDishQuery query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
    }
}
