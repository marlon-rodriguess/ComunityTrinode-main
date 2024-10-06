using FluentValidation;

namespace Trinode.Application.UseCases.GetIdUser
{
    public class GetByIdValidator : AbstractValidator<GetByIdRequest>
    {
        public GetByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}

