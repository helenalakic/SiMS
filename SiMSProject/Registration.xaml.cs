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
using System.Windows.Forms;
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
        private void ToAllUsers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AllUsers.xaml", UriKind.Relative));

        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
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
                System.Windows.MessageBox.Show("This user already exist!");
                return;
            }

            userController.Add(registredUser);
            System.Windows.MessageBox.Show("The user has been added to the list of all users");
            
        }

        private void ToCreateMedicine(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("CreateMedicine.xaml", UriKind.Relative));

        }
    }
}
