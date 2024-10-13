using Application.Features.Dishes.Queries.GetPaginatedDishes;
using Application.Response;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Reservations.Queries.GetAllDishes
{
    public class GetDishQuery : IRequest<ApiResponse<GetDishResponse>>
    {
        [Required]
        public string Category { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
