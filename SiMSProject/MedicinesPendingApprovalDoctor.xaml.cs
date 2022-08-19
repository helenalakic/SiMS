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
    /// Interaction logic for MedicinesPendingApprovalDoctor.xaml
    /// </summary>
    public partial class MedicinesPendingApprovalDoctor : Page
    {
        private MedicineController medicineController;
        private List<Medicine> PendingApprovalMedicineList { get; set; }
        private ObservableCollection<Medicine> PendingApprovalMedicines { get; set; }

        public MedicinesPendingApprovalDoctor()
        {
            InitializeComponent();
            this.DataContext = this;

            medicineController = new MedicineController();
            PendingApprovalMedicineList = new List<Medicine>();
            PendingApprovalMedicines = new ObservableCollection<Medicine>();

            PendingApprovalMedicineList = medicineController.GetAllPendingApprovalMedicines();

            foreach (Medicine m in PendingApprovalMedicineList)
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

        private void Medicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("DoctorHome.xaml", UriKind.Relative));

        }

        private void dataGridMedicines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
