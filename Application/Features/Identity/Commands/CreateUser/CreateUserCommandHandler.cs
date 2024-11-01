using Application.Contracts.Identity;
using Application.Contracts.Repos;
using Application.Response;
using MediatR;

namespace Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ApiResponse<CreateUserCommandResponse>>
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ILocationRepo _locationRepo;
        private readonly IClientRepo _clientRepo;

        public CreateUserCommandHandler(IClientRepo clientRepo, ILocationRepo locationRepo, IAuthorizationService authorizationService)
        {
            _clientRepo = clientRepo;
            _locationRepo = locationRepo;
            _authorizationService = authorizationService;
        }

        public async Task<ApiResponse<CreateUserCommandResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var id = await _authorizationService.CreateAsync(request);

            if (id.IsSuccessStatusCode)
            {
                var client = new Domain.Entities.Client
                {
                    Id = id.Data.UserId,
                    Birthday = request.Birthday.ToUniversalTime(), // Ensure it's in UTC
                    Email = request.Email,
                    FirstName = request.FirstName,
                    Password = request.Password,
                    Gender = request.Gender,
                    MobileNumber = request.MobileNumber,
                    LastName = request.LastName,
                    RememberMe = request.RememberMe,
                };
                await _clientRepo.AddAsync(client);
                await _locationRepo.AddAsync(new Domain.Entities.Location { Id = new Guid(), Name = request.Locations.First().Name, Lat = request.Locations.First().Lat, Long = request.Locations.First().Long, ClientId = id.Data.UserId });
            }
            return id;
        }
    }
}
