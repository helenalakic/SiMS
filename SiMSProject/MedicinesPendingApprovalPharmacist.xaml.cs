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
    /// Interaction logic for MedicinesPendingApprovalPharmacist.xaml
    /// </summary>
    public partial class MedicinesPendingApprovalPharmacist : Page
    {
        private MedicineController medicineController;
        private List<Medicine> PendingApprovalMedicineList { get; set; } 
        private ObservableCollection<Medicine> PendingApprovalMedicines { get; set; }

        public MedicinesPendingApprovalPharmacist()
        {
            InitializeComponent();
            this.DataContext = this;

            medicineController = new MedicineController();
            PendingApprovalMedicineList = new List<Medicine>();
            PendingApprovalMedicines = new ObservableCollection<Medicine>();

            PendingApprovalMedicineList = medicineController.GetAllPendingApprovalMedicines();

            foreach(Medicine m in PendingApprovalMedicineList)
            {
                PendingApprovalMedicines.Add(m);
            }
            dataGridMedicines.ItemsSource = PendingApprovalMedicines;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {

        }

        private void ConfirmButton(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {

        }

        private void MedicinesPendingApproval(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MedicinesPendingApprovalPharmacist.xaml", UriKind.Relative));

        }

        private void AcceptedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AcceptedMedicines.xaml", UriKind.Relative));

        }

        private void RefusedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("RefusedMedicines.xaml", UriKind.Relative));

        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PharmacistHome.xaml", UriKind.Relative));

        }
    }
}
