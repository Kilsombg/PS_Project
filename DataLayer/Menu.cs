using DataLayer.Database;
using DataLayer.Model;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Menu
    {
        private readonly DatabaseUserService userService;

        public Menu(DatabaseUserService userService)
        {
            this.userService = userService;
        }

        public void Invoke()
        {
            while (true)
            {
                Console.WriteLine("Choose a number:");
                Console.WriteLine("1 : Take all users");
                Console.WriteLine("2 : Add user");
                Console.WriteLine("3 : Delete user");

                int choice = 0;
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                switch (choice)
                {
                    case 1:
                        {
                            List<DatabaseUser> users = userService.GetAll();

                            userService.PrintAll(users);

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter username: ");

                            string name = Console.ReadLine();

                            Console.Write("Enter username: ");

                            string password = Console.ReadLine();

                            userService.AddUser(name, password);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter name");

                            string name = Console.ReadLine();

                            userService.RemoveUser(name);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong instruction!");
                            break;
                        }
                };
            }
        }
    }
}
