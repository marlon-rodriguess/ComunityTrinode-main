using System.Security.Cryptography;
using System.Text;

namespace Trinode.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get;  set; }
        public string Email { get;  set; }
        public  string Salt { get ;  set; }
        public  string Password { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public IList<Course> Courses { get; set; }
    }
}

