namespace Trinode.Domain.Entities
{
    public class Module : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
        public int Lectures { get; set; }
    }
}

