using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string Name {get; set; }
        public string Password { get; set; }
        public UserRolesEnum Role { get; set; }
        public string FacultyNumber { get; set; }
        public string Email { get; set; }
        public virtual int Id { get; set; }
        public DateTime Expired { get; set; }

        public User(string Name, string Password, UserRolesEnum Role, string FacultyNumber, string Email)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
            this.FacultyNumber = FacultyNumber;
            this.Email = Email;
        }
        public User()
        {
            
        }
    }
}
