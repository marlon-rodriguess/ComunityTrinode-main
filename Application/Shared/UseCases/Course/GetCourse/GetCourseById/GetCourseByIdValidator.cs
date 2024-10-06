using FluentValidation;
using Trinode.Application.UseCases.GetIdUser;

namespace Trinode.Application.UseCases.GetCourse.GetCourseById
{
    public class GetCourseByIdValidator : AbstractValidator<GetByIdResponse>
    {
        public GetCourseByIdValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .WithMessage("Course cannot be null");
        }
    }
}

