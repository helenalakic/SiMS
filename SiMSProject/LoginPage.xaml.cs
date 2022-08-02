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

        //public Frame _mainFrame;
        ////private Thread thread;
        //Window MainWindow;

        //public LoginPage(Window mainWindow)
        //{
        //    InitializeComponent();
        //    _mainFrame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
        //    MainWindow = mainWindow;

        //    //thread = new Thread(new ThreadStart(ThreadProc));
        //}

        //public void LoginUser(object sender, RoutedEventArgs e)
        //{
        //    string username = usernameTB.Text;
        //    string password = passwordTB.Text;

        //    usernameTB.Clear();
        //    passwordTB.Clear();

        //    PersonController pc = new PersonController();

        //    if (!pc.Login(username, password, _mainFrame, thread, MainWindow))
        //    {
        //        MessageBox.Show("Username or password doesn't match");
        //    }

        //}
        private MainWindow mainWindow;

        public LoginPage(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        private void LoginUser(object sender, RoutedEventArgs e)
        {

        }
    }
}
