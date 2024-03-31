using DataLayer.Database;
using DataLayer.Model;
using DataLayer.Services;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();

                DatabaseUserService userService = new DatabaseUserService(context);

                var menu = new Menu(userService);
                menu.Invoke();

                //Console.ReadKey();
            }
        }
    }
}