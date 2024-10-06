using FluentValidation;

namespace Trinode.Application.UseCases.UpdateUser
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}

