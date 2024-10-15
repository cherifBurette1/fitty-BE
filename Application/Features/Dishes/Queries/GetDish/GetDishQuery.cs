using Application.Response;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Reservations.Queries.GetDish
{
    public class GetDishQuery : IRequest<ApiResponse<GetDishQueryResponse>>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
