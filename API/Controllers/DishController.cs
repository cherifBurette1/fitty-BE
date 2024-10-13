using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Dishes.Queries.GetPaginatedDishes;
using Application.Features.Reservations.Queries.GetAllDishes;
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
        [AllowAnonymous]
        [HttpPost("AddDish")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(CreateDishCommandResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> AddDish([FromBody] CreateDishCommand query)
        {
            var result = await _mediator.Send(query);

            return GetApiResponse(result);
        }
    }
}
