using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;

namespace Welcome.Helpers
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
    }
}
