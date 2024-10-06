using FluentValidation;

namespace Trinode.Application.UseCases.DeleteUser
{
    public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.id).NotEmpty();
        }
    }
}

