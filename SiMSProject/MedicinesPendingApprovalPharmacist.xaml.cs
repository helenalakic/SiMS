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
    /// Interaction logic for MedicinesPendingApprovalPharmacist.xaml
    /// </summary>
    public partial class MedicinesPendingApprovalPharmacist : Page
    {
        private MedicineController medicineController;
        private List<Medicine> PendingApprovalMedicineList { get; set; } 
        private ObservableCollection<Medicine> PendingApprovalMedicines { get; set; }

        public static Medicine pa { get; set; }

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

        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }


        private void ToAcceptedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AcceptedMedicines.xaml", UriKind.Relative));

        }

        private void ToRefusedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("RefusedMedicines.xaml", UriKind.Relative));

        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PharmacistHome.xaml", UriKind.Relative));

        }

        private void AcceptButton(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Are you sure you want to approve the medicine?","Question", MessageBoxButton.YesNo);
        }

        private void DeclineButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(pa.MedicineName);
            Window win = new ReasonForRejection(pa);
            win.ShowDialog();
        }
    }
}
