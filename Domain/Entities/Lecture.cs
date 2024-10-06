namespace Trinode.Domain.Entities
{
    public class Lecture : BaseEntity
    {
        public string Name { get; set; }
        public Guid ModuleGuid { get; set; }
        public string VideoUrl { get; set; }
        public string GithubUrl { get; set; }
    }
}

