using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            string displayMSG = String.Format($"Welcome\n" +
                $"User:{_viewModel.Name}\n" +
                $"Role:{_viewModel.Role}\n" +
                $"FacultyNumber: {_viewModel.FacultyNumber}\n" +
                $"Email: {_viewModel.Email}");

            Console.WriteLine(displayMSG);

        }

        public void DisplayError(string message)
        {
            throw new Exception(message);
        }
    }                         
}
