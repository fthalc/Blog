using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public byte[] PasswordHash { get; set; } // sha256 md5
        public String UserName { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public String Picture { get; set; }
        public String Description { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
