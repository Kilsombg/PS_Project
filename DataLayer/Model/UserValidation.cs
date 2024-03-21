using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer.Model
{
    public static class UserValidation
    {
        public static DatabaseContext context = new DatabaseContext();

        public static bool IsExist(string username, string password)
        {
            return context.Users.Any(x => x.Name == username && x.Password == password);
        }
    }
}
