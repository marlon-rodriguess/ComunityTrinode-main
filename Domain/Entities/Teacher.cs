namespace Trinode.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string HashPassword { get; private set; }
        public string Salt { get; private set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IList<Course> Courses { get; set; }
    }   
}

