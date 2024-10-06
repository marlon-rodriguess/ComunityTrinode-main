using AutoMapper;
using MediatR;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.GetCourse
{
    public class GetCourseCategoryHandler : IRequestHandler<GetCourseCategoryRequest, GetCourseCategoryResponse>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly IDbCommit _dbCommit;

        public GetCourseCategoryHandler(ICourseRepository courseRepository, IMapper mapper, IDbCommit dbCommit)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _dbCommit = dbCommit;
        }
        public async Task<GetCourseCategoryResponse> Handle(GetCourseCategoryRequest request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetByCategory(request.CategoryId, cancellationToken);
            return _mapper.Map<GetCourseCategoryResponse>(courses);
        }
    }
}

