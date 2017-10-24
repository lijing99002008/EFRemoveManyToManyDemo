using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFRemoveManyToManyDemo_ljy.Model
{
    public class User
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
