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
    /// Interaction logic for DoctorHome.xaml
    /// </summary>
    public partial class DoctorHome : Page
    {
        private MedicineController medicineController;
        private List<Medicine> MedicineList { get; set; }
        private ObservableCollection<Medicine> Medicines { get; set; }
        public static Medicine selectedMedicineDh { get; set; }

        public DoctorHome()
        {
            InitializeComponent();
            this.DataContext = this;

            TextBoxMin.Text = "Min";
            TextBoxMin.Foreground = Brushes.Gray;
            TextBoxMax.Text = "Max";
            TextBoxMax.Foreground = Brushes.Gray;

            medicineController = new MedicineController();
            MedicineList = new List<Medicine>();
            Medicines = new ObservableCollection<Medicine>();

            //Medicine m = new Medicine();
            //m.MedicineId = "22";
            //m.MedicineName = "brufen";
            //m.Manufacturer = "galen";
            ////          m.INGREDIENT = "a";
            //m.Quantity = 10;
            //m.QuantityInStock = 50;
            //m.Price = 1000;

            //Medicine m1 = new Medicine();
            //m1.MedicineId = "55";
            //m1.MedicineName = "rapten";
            //m1.Manufacturer = "pharm";
            //m1.Quantity = 70;
            //m1.QuantityInStock = 20;
            //m1.Price = 3500;

            //Medicine m2 = new Medicine();
            //m2.MedicineId = "100";
            //m2.MedicineName = "paracetamol";
            //m2.Manufacturer = "pharm";
            //m2.Quantity = 5;
            //m2.QuantityInStock = 1;
            //m2.Price = 200;

            //medicineController.Add(m);
            //medicineController.Add(m1);
            //medicineController.Add(m2);

            MedicineList = medicineController.GetAllAcceptedMedicines();

            foreach (Medicine k in MedicineList)
            {
                Medicines.Add(k);
            }

            dataGridMedicines.ItemsSource = Medicines;
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var comboBoxSearchName = ComboBoxSearch.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (comboBoxSearchName.Equals("Medicine id"))
            {
                var resultList = Medicines.Where(medicine => medicine.MedicineId.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList;
                return;
            }
            if (comboBoxSearchName.Equals("Medicine name"))
            {
                var resultList = Medicines.Where(medicine => medicine.MedicineName.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Manufacturer"))
            {
                var resultList = Medicines.Where(medicine => medicine.Manufacturer.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Price range"))
            {
                return;

            }
            if (comboBoxSearchName.Equals("Quantity"))
            {
                var resultList = Medicines.Where(medicine => medicine.Quantity.ToString().Contains(TextBoxSearch.Text));
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
                MedicineList.Sort((x, y) => x.MedicineName.CompareTo(y.MedicineName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Price"))
            {
                MedicineList.Sort((x, y) => x.Price.CompareTo(y.Price));
                SortListToObsCollection();
                return;
            }
            
            if (comboBoxSortName.Equals("Quantity in stock"))
            {
                MedicineList.Sort((x, y) => x.QuantityInStock.CompareTo(y.QuantityInStock));
                SortListToObsCollection();
                return;
            }
        }

        public void SortListToObsCollection()
        {
            ObservableCollection<Medicine> sortedMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine k in MedicineList)
            {
                sortedMedicines.Add(k);
            }
            Medicines = sortedMedicines;
            dataGridMedicines.ItemsSource = Medicines;
        }

        private void ToMedicinesPendingApproval(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MedicinesPendingApprovalDoctor.xaml", UriKind.Relative));

        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }

        private void IngredientsButton(object sender, RoutedEventArgs e)
        {
            var allIngredients = string.Join("\r\n", selectedMedicineDh.Ingredients.Values.Select(x => "Name: " + x.IngredientName + ", Description: " + x.IngredientDescription).ToList());
            System.Windows.MessageBox.Show("All ingredients: \r\n" + allIngredients);
        }
        private void SearchByPrice(object sender, RoutedEventArgs e)
        {
            var resultMin = string.IsNullOrEmpty(this.TextBoxMin.Text) ? 0.0 : Double.Parse(this.TextBoxMin.Text);
            var resultMax = string.IsNullOrEmpty(this.TextBoxMax.Text) ? 0.0 : Double.Parse(this.TextBoxMax.Text);

            List<Medicine> medicinePriceList = new List<Medicine>();
            medicinePriceList = medicineController.GetPricesOfAcceptedMedicines(resultMin, resultMax);

            Medicines = new ObservableCollection<Medicine>();
            foreach (Medicine m in medicinePriceList)
            {
                Medicines.Add(m);
            }
            dataGridMedicines.ItemsSource = Medicines;


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
            if (TextBoxMax.Text.Trim().Equals("Max"))
            {
                TextBoxMax.Text = "";
                TextBoxMax.Foreground = Brushes.Black;
            }

        }

        private void textBoxMax_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxMax.Text.Trim().Equals(String.Empty))
            {
                TextBoxMax.Text = "Max";
                TextBoxMax.Foreground = Brushes.Gray;
            }
        }
    }
}
