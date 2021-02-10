using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginHash.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
          
        public virtual ICollection<SystemUser> SystemUser { get; set; }
    }
    public class SystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string saltIguess { get; set; }        
    } 
}
