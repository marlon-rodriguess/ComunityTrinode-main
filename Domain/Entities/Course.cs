namespace Trinode.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public string Technology { get; set; }
        public decimal TotalHours { get; set; }
        public IList<Module> Modules { get; set; }
        public IList<Teacher> Teachers { get; set; }
        public IList<User> Users { get; set; }
    }
}

