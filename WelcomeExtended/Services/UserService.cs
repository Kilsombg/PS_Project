using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using Welcome.Helpers;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended.Services
{
    public class UserService
    {
        private readonly UserData data;
        private readonly ILogger log;

        public UserService(UserData data, ILogger log)
        {
            this.data = data;
            this.log = log;
        }

        public User Login(string name, string password)
        {
            User user = new User();
            try
            {
                if (data.ValidateCredentials(name, password))
                {
                    user = data.Login(name, password);
                    log.LogInformation($"Successfully login user: {name}");
                    Console.WriteLine(user.ConvertToString());
                }
                else
                {
                    throw new Exception("User not found");
                }
            }
            catch(Exception ex)
            {
                log.LogError(ex.Message);
            }
            
            return user;
        }
    }
}
