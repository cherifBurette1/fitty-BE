using Application.Response;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<ApiResponse<CreateUserCommandResponse>>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool RememberMe { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public List<AddLocationCommand> Locations { get; set; }

    }
    public class AddLocationCommand
    {
        [Required]
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public string Address { get; set; }
        public string AdditionalDetails { get; set; }
    }
}
