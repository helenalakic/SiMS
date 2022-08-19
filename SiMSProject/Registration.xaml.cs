using Model;
using SiMSProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private UserController userController;

        public Registration()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ManagerHome.xaml", UriKind.Relative));

        }
        private void AllUsers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AllUsers.xaml", UriKind.Relative));

        }

        private void GoBack(object sender, RoutedEventArgs e)
        {

        }

        private void ClickToRegisterUser(object sender, RoutedEventArgs e)
        {
            var firstName = this.firstName.Text;
            var lastName = this.lastName.Text;
            var phoneNumber = this.phoneNumber.Text;
            var umcn = this.umcn.Text;
            var email = this.email.Text;
            var password = this.password.Text;
            var userType = this.ComboBoxUser.Text;
            Console.WriteLine(userType);

            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.PhoneNumber = phoneNumber;
            user.Email = email; 
            user.Password = password;
            user.Umcn = umcn;
            if(userType.Equals(UserTypeEnum.Pharmacist.ToString()))
            {
                user.UserType = UserTypeEnum.Pharmacist;
            }
            if (userType.Equals(UserTypeEnum.Doctor.ToString()))
            {
                user.UserType = UserTypeEnum.Doctor;
            }

            User registredUser = new User();
            registredUser = userController.RegisterUser(user);

            if(registredUser == null)
            {
                MessageBox.Show("This user already exist!");
                return;
            }

            userController.Add(registredUser);
            MessageBox.Show("The user has been added to the list of all users");
            
        }
    }
}
