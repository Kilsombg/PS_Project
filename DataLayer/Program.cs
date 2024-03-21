using DataLayer.Database;
using DataLayer.Model;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add(new DatabaseUser()
                {
                    Name = "user",
                    Password = "password",
                    Expired = DateTime.Now,
                    Role = Welcome.Others.UserRolesEnum.STUDENT,
                    FacultyNumber = "",
                    Email = "",
                });
                context.SaveChanges();
                var users = context.Users.ToList();

                Console.WriteLine("Enter username:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                if (UserValidation.IsExist(name, password))
                {
                    Console.WriteLine("Valid user");
                }
                else
                {
                    Console.WriteLine("Invalid user");
                }


                //Console.ReadKey();
            }
        }
    }
}