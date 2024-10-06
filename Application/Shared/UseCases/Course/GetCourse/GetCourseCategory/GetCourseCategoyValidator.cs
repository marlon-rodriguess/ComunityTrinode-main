using FluentValidation;

namespace Trinode.Application.UseCases.GetCourse
{
    public class GetCourseCategoyValidator : AbstractValidator<GetCourseCategoryRequest>
    {
        public GetCourseCategoyValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .WithMessage("Course cannot be null");
        }
    }
}

