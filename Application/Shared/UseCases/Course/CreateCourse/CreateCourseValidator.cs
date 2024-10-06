using FluentValidation;

namespace Trinode.Application.UseCases
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");    
        }
    }
}

