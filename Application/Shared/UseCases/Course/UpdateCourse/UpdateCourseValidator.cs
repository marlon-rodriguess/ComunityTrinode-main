using FluentValidation;
using Trinode.Application.UseCases.UpdateCourse;

namespace Trinode.Application.UseCases.UpdateCourse
{
    public class UpdateCourseValidator : AbstractValidator<UpdateCourseRequest>
    {
        public UpdateCourseValidator()
        {
            RuleFor(x => x.NewCourse)
                .NotNull()
                .WithMessage("Course cannot be null");
        }
    }
}

