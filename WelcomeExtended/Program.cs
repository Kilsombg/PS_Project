using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var ViewModel = new UserViewModel(user);

                UserView view = new UserView(ViewModel);

                view.Display();

                view.DisplayError("error");
                view.DisplayError("error2");
            }
            catch (Exception ex) {
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
