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
using System.Windows.Forms;
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
        public static User au { get; set; }


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
            //var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            //Console.WriteLine(ComboBoxSort.SelectedItem);

            //if (comboBoxSortName.Equals("First name"))
            //{
            //    UsersList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
            //    SortListToObsCollection();
            //    return;
            //}

            //if (comboBoxSortName.Equals("Last name"))
            //{
            //    UsersList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            //    SortListToObsCollection();
            //    return;
            //}
            var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            var comboBoxSortAscDesc = ComboBoxSortBy.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if(comboBoxSortName == null)
            {
                System.Windows.MessageBox.Show("Select a sort method!");
                return;
            }
            if (comboBoxSortName.Equals("First name") && comboBoxSortAscDesc.Equals("Ascending"))
            {
                UsersList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                SortListToObsCollection();
                return;
            }
            if (comboBoxSortName.Equals("First name") && comboBoxSortAscDesc.Equals("Descending"))
            {
                UsersList.Sort((x, y) => y.FirstName.CompareTo(x.FirstName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Last name") && comboBoxSortAscDesc.Equals("Ascending"))
            {
                UsersList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                SortListToObsCollection();
                return;
            }
            if (comboBoxSortName.Equals("Last name") && comboBoxSortAscDesc.Equals("Descending"))
            {
                UsersList.Sort((x, y) => y.LastName.CompareTo(x.LastName));
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
            var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            var comboBoxSortAscDesc = ComboBoxSortBy.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (comboBoxSortAscDesc == null)
            {
                System.Windows.MessageBox.Show("Choose what to sort by!");
                return;
            }
            if (comboBoxSortName.Equals("First name") && comboBoxSortAscDesc.Equals("Ascending"))
            {
                UsersList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                SortListToObsCollection();
                return;
            }
            if (comboBoxSortName.Equals("First name") && comboBoxSortAscDesc.Equals("Descending"))
            {
                UsersList.Sort((x, y) => y.FirstName.CompareTo(x.FirstName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Last name") && comboBoxSortAscDesc.Equals("Ascending"))
            {
                UsersList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                SortListToObsCollection();
                return;
            }
            if (comboBoxSortName.Equals("Last name") && comboBoxSortAscDesc.Equals("Descending"))
            {
                UsersList.Sort((x, y) => y.LastName.CompareTo(x.LastName));
                SortListToObsCollection();
                return;
            }

        }

        private void BlockButton(object sender, RoutedEventArgs e)
        {
            userController.BlockUser(au);
            System.Windows.Controls.Button Block_btn = (System.Windows.Controls.Button)sender;
            Block_btn.IsEnabled = false;
        }
        async Task Button1Clicked()
        {
            button2Disabled = true;
            await Task.Delay(3000);
            button2Disabled = false;
        }

        async Task Button2Clicked()
        {
            if (button2Disabled == false) // optional guard
            {
            }
        }

        private void UnblockButton(object sender, RoutedEventArgs e)
        {
            userController.UnblockUser(au);
            System.Windows.Controls.Button Unblock_btn = (System.Windows.Controls.Button)sender;
            Unblock_btn.IsEnabled = false;
        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ManagerHome.xaml", UriKind.Relative));

        }

        private void ToRegistration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration.xaml", UriKind.Relative));

        }

        private void FilterBy(object sender, SelectionChangedEventArgs e)
        {
            var ComboBoxFilterBy = ComboBoxFilter.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (ComboBoxFilterBy.Equals("Doctor"))
            {
                var resultList = Users.Where(user => user.UserType == UserTypeEnum.Doctor);
                dataGridUsers.ItemsSource = resultList;
            }
            if (ComboBoxFilterBy.Equals("Pharmacist"))
            {
                var resultList = Users.Where(user => user.UserType == UserTypeEnum.Pharmacist);
                dataGridUsers.ItemsSource = resultList;
            }

        }
        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }

        private void ToCreateMedicine(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("CreateMedicine.xaml", UriKind.Relative));

        }
    }
}
