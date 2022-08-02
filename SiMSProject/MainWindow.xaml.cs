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
            LoginPage loginPage = new LoginPage();
            MainFrame.NavigationService.Navigate(loginPage);
            
            // za prvi put zbog upisa u datoteku
            // UserController = new UserController();
            //User user = new User();
            //user.UMCN = "123";
            //user.EMAIL = "hela";
            //user.PASSWORD = "1";
            //user.FIRSTNAME = "helena";
            //user.LASTNAME = "lakic";
            //user.PHONENUMBER = "555";
            //user.USERTYPE = UserType.Doctor;

            //User user1 = new User();
            //user1.UMCN = "222";
            //user1.EMAIL = "maga";
            //user1.PASSWORD = "2";
            //user1.FIRSTNAME = "magdalena";
            //user1.LASTNAME = "lakic";
            //user1.PHONENUMBER = "333";
            //user1.USERTYPE = UserType.Pharmacist;

            //User user2 = new User();
            //user2.UMCN = "444";
            //user2.EMAIL = "boka";
            //user2.PASSWORD = "3";
            //user2.FIRSTNAME = "bojana";
            //user2.LASTNAME = "zekanovic";
            //user2.PHONENUMBER = "777";
            //user2.USERTYPE = UserType.Pharmacist;

            //User user3 = new User();
            //user3.UMCN = "999";
            //user3.EMAIL = "vanja";
            //user3.PASSWORD = "4";
            //user3.FIRSTNAME = "vanja";
            //user3.LASTNAME = "teodorovic";
            //user3.PHONENUMBER = "11";
            //user3.USERTYPE = UserType.Manager;

            //UserController.Add(user);
            //UserController.Add(user1);
            //UserController.Add(user2);
            //UserController.Add(user3);


        }

    }
}
