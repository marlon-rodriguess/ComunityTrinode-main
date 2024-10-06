using System;

namespace Trinode.Application.UseCases.CreateUser
{
    public sealed class CreateUserResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}

