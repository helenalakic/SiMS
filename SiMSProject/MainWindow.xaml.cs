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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController UserController;

        public MainWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage(this);
            MainFrame.NavigationService.Navigate(loginPage);
            UserController = new UserController();



            User user = new User();
            user.UMCN = "123";
            user.EMAIL = "hela";
            user.PASSWORD = "1";
            user.FIRSTNAME = "helena";
            user.LASTNAME = "lakic";
            user.PHONENUMBER = "555";
            user.USERTYPE = UserType.Doctor;
            UserController.Add(user);


        }

    }
}
