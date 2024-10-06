using System.Diagnostics;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases
{
    public sealed class CreateCourseResponse
    {
        public int StatusCode {get; set;}
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public string? Technology { get; set; }
        public decimal? TotalHours { get; set; }
        public IList<Module> Modules { get; set; }
        public IList<Teacher> Teachers { get; set; }
    }
}
