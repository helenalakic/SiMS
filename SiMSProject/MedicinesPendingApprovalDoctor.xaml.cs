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
    /// Interaction logic for MedicinesPendingApprovalDoctor.xaml
    /// </summary>
    public partial class MedicinesPendingApprovalDoctor : Page
    {
        private MedicineController medicineController;
        private List<Medicine> PendingApprovalMedicineList { get; set; }
        private ObservableCollection<Medicine> PendingApprovalMedicines { get; set; }
        public static Medicine pa { get; set; }


        public MedicinesPendingApprovalDoctor()
        {
            InitializeComponent();
            this.DataContext = this;

            TextBoxMin.Text = "Min";
            TextBoxMin.Foreground = Brushes.Gray;
            TextBoxMax.Text = "Max";
            TextBoxMax.Foreground = Brushes.Gray;

            medicineController = new MedicineController();
            PendingApprovalMedicineList = new List<Medicine>();
            PendingApprovalMedicines = new ObservableCollection<Medicine>();
            pa = new Medicine();

            PendingApprovalMedicineList = medicineController.GetAllPendingApprovalMedicines();

            foreach (Medicine m in PendingApprovalMedicineList)
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

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("DoctorHome.xaml", UriKind.Relative));

        }

        private void dataGridMedicines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeclineButton(object sender, RoutedEventArgs e)
        {
            User u = LoginPage.LoggedUser;

            Window win = new ReasonForRejection(pa, u);
            win.ShowDialog();
        }

        private void AcceptButton(object sender, RoutedEventArgs e)
        {
            User u = LoginPage.LoggedUser;

            foreach (User user in pa.AcceptedByUsers)
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

            if (countDoctors >= 1 && countPharmacists >= 2)
            {
                pa.MedicineStatus = MedicineStatusEnum.Accepted;
                medicineController.Update(pa);
                System.Windows.MessageBox.Show("Medicine is accepted and you can find it in list of All Medicines");

                PendingApprovalMedicines.Remove(pa);
                dataGridMedicines.ItemsSource = PendingApprovalMedicines;
            }
        }
        private void ApprovedByButton(object sender, RoutedEventArgs e)
        {

            var approvedByUserType = string.Join(" ", pa.AcceptedByUsers.Select(user => user.UserType).ToList());
            System.Windows.MessageBox.Show("This medicine is approved by: " + approvedByUserType);
        }

        private void IngredientsButton(object sender, RoutedEventArgs e)
        {
            var allIngredients = string.Join("\r\n", pa.Ingredients.Values.Select(x => "Name: " + x.IngredientName + ", Description: " + x.IngredientDescription).ToList());
            System.Windows.MessageBox.Show("All ingredients: \r\n" + allIngredients);
        }
        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var comboBoxSearchName = ComboBoxSearch.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (comboBoxSearchName.Equals("Medicine id"))
            {
                var resultList = PendingApprovalMedicines.Where(medicine => medicine.MedicineId.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList;
                return;
            }
            if (comboBoxSearchName.Equals("Medicine name"))
            {
                var resultList = PendingApprovalMedicines.Where(medicine => medicine.MedicineName.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Manufacturer"))
            {
                var resultList = PendingApprovalMedicines.Where(medicine => medicine.Manufacturer.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Price range"))
            {
                return;

            }
            if (comboBoxSearchName.Equals("Quantity"))
            {
                var resultList = PendingApprovalMedicines.Where(medicine => medicine.Quantity.ToString().Contains(TextBoxSearch.Text));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Ingredients"))
            {
                //kod za pretragu
                return;
            }
        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            Console.WriteLine(ComboBoxSort.SelectedItem);

            if (comboBoxSortName.Equals("Medicine name"))
            {
                PendingApprovalMedicineList.Sort((x, y) => x.MedicineName.CompareTo(y.MedicineName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Price"))
            {
                PendingApprovalMedicineList.Sort((x, y) => x.Price.CompareTo(y.Price));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Quantity in stock"))
            {
                PendingApprovalMedicineList.Sort((x, y) => x.QuantityInStock.CompareTo(y.QuantityInStock));
                SortListToObsCollection();
                return;
            }
        }

        public void SortListToObsCollection()
        {
            ObservableCollection<Medicine> sortedMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine k in PendingApprovalMedicineList)
            {
                sortedMedicines.Add(k);
            }
            PendingApprovalMedicines = sortedMedicines;
            dataGridMedicines.ItemsSource = PendingApprovalMedicines;
        }
        private void SearchByPrice(object sender, RoutedEventArgs e)
        {
            var resultMin = string.IsNullOrEmpty(this.TextBoxMin.Text) ? 0.0 : Double.Parse(this.TextBoxMin.Text);
            var resultMax = string.IsNullOrEmpty(this.TextBoxMax.Text) ? 0.0 : Double.Parse(this.TextBoxMax.Text);

            List<Medicine> medicinePriceList = new List<Medicine>();
            medicinePriceList = medicineController.GetPricesOfPendingApprovalMedicines(resultMin, resultMax);

            PendingApprovalMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine m in medicinePriceList)
            {
                PendingApprovalMedicines.Add(m);
            }
            dataGridMedicines.ItemsSource = PendingApprovalMedicines;


        }

        private void ComboBoxSearchByChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxSearch.SelectedItem == null || !ComboBoxSearch.SelectedItem.ToString().Split(':')[1].TrimStart(' ').Equals("Price range"))
            {
                return;
            }
            this.TextBoxSearch.Visibility = Visibility.Hidden;
            this.TextBoxMin.Visibility = Visibility.Visible;
            this.TextBoxMax.Visibility = Visibility.Visible;
            this.SearchPrice_btn.Visibility = Visibility.Visible;
        }
        private void textBoxMin_GetFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxMin.Text.Trim().Equals("Min"))
            {
                TextBoxMin.Text = "";
                TextBoxMin.Foreground = Brushes.Black;
            }
        }

        private void textBoxMin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxMin.Text.Trim().Equals(String.Empty))
            {
                TextBoxMin.Text = "Min";
                TextBoxMin.Foreground = Brushes.Gray;
            }
        }

        private void textBoxMax_GetFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxMax.Text.Trim().Equals("Min"))
            {
                TextBoxMax.Text = "";
                TextBoxMax.Foreground = Brushes.Black;
            }

        }

        private void textBoxMax_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxMax.Text.Trim().Equals(String.Empty))
            {
                TextBoxMax.Text = "Min";
                TextBoxMax.Foreground = Brushes.Gray;
            }
        }
    }
}
