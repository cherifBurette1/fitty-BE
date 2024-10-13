using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Dishes.Queries.GetPaginatedDishes;
using Application.Features.Reservations.Queries.GetAllDishes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet("GetAllCategories")]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(GetAllCategoriesQueryResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllCategories()
        {
            var result = await _mediator.Send(new GetAllCategoriesQuery());

            return GetApiResponse(result);
        }
    }
}
