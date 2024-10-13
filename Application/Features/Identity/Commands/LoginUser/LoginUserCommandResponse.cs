﻿namespace Application.Features.Identity.Commands.LoginUser
{
    public class LoginUserCommandResponse
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
