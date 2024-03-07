using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ConvertToString(this User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User{\n");
            sb.Append($"Id: {user.Id},\n");
            sb.Append($"Name: {user.Name},\n");
            sb.Append($"FacultyNumber: {user.FacultyNumber},\n");
            sb.Append($"Role: {user.Role},\n");
            sb.Append("}");

            return sb.ToString();
        }

        public static bool ValidateCredentials(this UserData data, string name, string password)
        {
                if (name == null || name == "")
                {
                    throw new Exception("The {name} cannot be empty");
                }
                if (password == null || password == "")
                {
                    throw new Exception("The {password} cannot be empty");
                }

                return data.ValidateUser(name, password);
        }
        public static User Login(this UserData data, string name, string password)
        {   
            return data.GetUser(name, password);
        }

    }
}
