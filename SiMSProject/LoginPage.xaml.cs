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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public Frame _mainFrame;
        private UserController UserController;
        private int counter;

        public static User LoggedUser = new User();

        public LoginPage()
        {
            InitializeComponent();
            _mainFrame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
            UserController = new UserController();
            counter = 0;

        }


        private void LoginUser(object sender, RoutedEventArgs e)
        {
            //TO DO premjestiti u servis
            counter++;
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            
            LoggedUser = UserController.LoginUser(username, password);

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || usernameTextBox.Text == null || passwordTextBox.Text == null)
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            if (LoggedUser != null )
            {
                 if(LoggedUser.IsBlocked)
                 {
                    MessageBox.Show("User is blocked!");
                    return;
                 }
                NavigateToHomePage(LoggedUser);
            }
            else
            {
                MessageBox.Show("Incorrect email or password!");
                if (counter > 3)
                { 
                    MessageBox.Show("You cannot access the program!");
                    LoginButton.IsEnabled = false;
                }
            }
        }

        private void NavigateToHomePage (User u)
        {

            if (u.UserType.ToString().Equals("Doctor"))
            {
                DoctorHome doctorPage = new DoctorHome();
                _mainFrame.NavigationService.Navigate(doctorPage);
            }

            if (u.UserType.ToString().Equals("Pharmacist"))
            {
                PharmacistHome pharmacistPage = new PharmacistHome();
                _mainFrame.NavigationService.Navigate(pharmacistPage);
            }

            if (u.UserType.ToString().Equals("Manager"))
            {
                ManagerHome managerPage = new ManagerHome();
                _mainFrame.NavigationService.Navigate(managerPage);
            }
        }

    }
}
