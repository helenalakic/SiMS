using Model;
using SiMSProject.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AllUsers.xaml
    /// </summary>
    public partial class AllUsers : Page
    {
        private UserController userController;
        private List<User> UsersList { get; set; }
        private ObservableCollection<User> Users { get; set; }

        public AllUsers()
        {
            InitializeComponent();
            this.DataContext = this;

            userController = new UserController();
            UsersList = new List<User>();
            Users = new ObservableCollection<User>();

            UsersList = userController.GetAllUsersExceptManager();
            foreach (User u in UsersList)
            {
                Users.Add(u);
            }
            dataGridUsers.ItemsSource = Users;
        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            Console.WriteLine(ComboBoxSort.SelectedItem);

            if (comboBoxSortName.Equals("First name"))
            {
                UsersList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Last name"))
            {
                UsersList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                SortListToObsCollection();
                return;
            }

        }
        public void SortListToObsCollection()
        {
            ObservableCollection<User> sortedUsers = new ObservableCollection<User>();
            foreach (User u in UsersList)
            {
                sortedUsers.Add(u);
            }
            Users = sortedUsers;
            dataGridUsers.ItemsSource = Users;
        }
        private void SortByAscDesc(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GoBack(object sender, RoutedEventArgs e)
        {

        }

        private void BlockButton(object sender, RoutedEventArgs e)
        {

        }

        private void UnblockButton(object sender, RoutedEventArgs e)
        {

        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ManagerHome.xaml", UriKind.Relative));

        }

        private void ClickToRegistration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration.xaml", UriKind.Relative));

        }
    }
}
