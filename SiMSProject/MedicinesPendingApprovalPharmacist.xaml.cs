using Model;
using SiMSProject.Controller;
using SiMSProject.Model;
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
            pa = new Medicine();

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
            User u = LoginPage.LoggedUser;

            foreach(User user in pa.AcceptedByUsers)
            {
                if (user.Umcn.Equals(u.Umcn))
                {
                    System.Windows.MessageBox.Show("You've already approved this medicine!");
                    return;
                }
            }

            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to approve this medicine", "Approve the medicine", MessageBoxButtons.YesNo)
               == (DialogResult)MessageBoxResult.Yes)
            {
                pa.AcceptedByUsers.Add(u);
                medicineController.Update(pa);
            }

            int countDoctors = pa.AcceptedByUsers.Where(x => x.UserType.ToString().Equals("Doctor")).ToList().Count();
            Console.WriteLine("BROJ DOKTORA U LISTI " + countDoctors);
            int countPharmacists = pa.AcceptedByUsers.Where(x => x.UserType.ToString().Equals("Pharmacist")).ToList().Count();
            Console.WriteLine("BROJ FARMACEUTaA U LISTI " + countPharmacists);

            if(countDoctors >= 1 && countPharmacists >= 2)
            {
                pa.MedicineStatus = MedicineStatusEnum.Accepted;
                medicineController.Update(pa);
                System.Windows.MessageBox.Show("Medicine is accepted and you can find it in list of All Medicines");

                PendingApprovalMedicines.Remove(pa);
                dataGridMedicines.ItemsSource = PendingApprovalMedicines;
            }
        }

        private void DeclineButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(pa.MedicineName);
            Window win = new ReasonForRejection(pa);
            win.ShowDialog();
        }

        private void ApprovedByButton(object sender, RoutedEventArgs e)
        {

            var approvedByUserType = string.Join(" ", pa.AcceptedByUsers.Select(user => user.UserType).ToList());
            System.Windows.MessageBox.Show("This medicine is approved by: " + approvedByUserType);
        }

        private void IngredientsButton(object sender, RoutedEventArgs e)
        {
            Window win = new Ingredients();
            win.ShowDialog();
        }
    }
}
