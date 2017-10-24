using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFRemoveManyToManyDemo_ljy.Model
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
