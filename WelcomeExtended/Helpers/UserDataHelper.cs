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
    public static class UserDataHelper
    {
        public static bool ValidateCredentials(this UserData data, string name, string password)
        {
                if (name == null || name == "")
                {
                    throw new Exception("The field {name} cannot be empty");
                }
                if (password == null || password == "")
                {
                    throw new Exception("The field {password} cannot be empty");
                }

                return data.ValidateUser(name, password);
        }
        public static User Login(this UserData data, string name, string password)
        {   
            return data.GetUser(name, password);
        }

    }
}
