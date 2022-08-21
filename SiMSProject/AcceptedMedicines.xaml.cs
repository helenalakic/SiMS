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
    /// Interaction logic for AcceptedMedicines.xaml
    /// </summary>
    public partial class AcceptedMedicines : Page
    {
        private MedicineController medicineController;
        private List<Medicine> AcceptedMedicinesList { get; set; }
        private ObservableCollection<Medicine> ConfirmedMedicines { get; set; }
        public AcceptedMedicines()
        {
            InitializeComponent();
            this.DataContext = this;

            medicineController = new MedicineController();
            AcceptedMedicinesList = new List<Medicine>();
            ConfirmedMedicines = new ObservableCollection<Medicine>();

            AcceptedMedicinesList = medicineController.GetAllAcceptedMedicines();

            foreach (Medicine m in AcceptedMedicinesList)
            {
                ConfirmedMedicines.Add(m);
            }

            dataGridMedicines.ItemsSource = ConfirmedMedicines;
        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ToMedicinesPendingApproval(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MedicinesPendingApprovalPharmacist.xaml", UriKind.Relative));

        }

        private void ToRefusedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("RefusedMedicines.xaml", UriKind.Relative));

        }
        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PharmacistHome.xaml", UriKind.Relative));

        }
        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }
    }
}
