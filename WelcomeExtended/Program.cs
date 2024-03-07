using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using static WelcomeExtended.Others.Delegates;
using static WelcomeExtended.Helpers.UserHelper;
using Microsoft.Extensions.Logging;
using WelcomeExtended.Loggers.LoginLogger;
using WelcomeExtended.Services;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
            path = Path.Combine(Path.GetDirectoryName(path), "logs");

            var logFactory = new LoggerFactory();
            logFactory.AddProvider(new LoginLoggerProvider(path));
            var loginLogger = logFactory.CreateLogger("Login");

            try
            {
                UserData userData = new UserData();
                User studentUser = new User()
                {
                    Name = "student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };
                userData.AddUser(studentUser);
                userData.AddUser(new User()
                {
                    Name = "Student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                });
                userData.AddUser(new User()
                {
                    Name = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                });
                userData.AddUser(new User()
                {
                    Name = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                });

                var userService = new UserService(userData, loginLogger);

                Console.WriteLine("Enter name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                var password = Console.ReadLine();

                var user = userService.Login(name, password);
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Log);
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
