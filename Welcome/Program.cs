using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ivan Kamenov", "1234", Others.UserRolesEnum.STUDENT, "123", "name@gmail.com");

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);

            userView.Display();

            // Console.WriteLine("Hello, World!");
        }
    }
}