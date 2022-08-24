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
    /// Interaction logic for RefusedMedicines.xaml
    /// </summary>
    public partial class RefusedMedicines : Page
    {
        private MedicineController medicineController;
        private List<Medicine> RefusedMedicineList { get; set; }
        private ObservableCollection<Medicine> RejectedMedicines { get; set; }
        public static Medicine rm { get; set; }

        private Medicine declineMedicine;
        private User userDeclined;

        public RefusedMedicines()
        {
            InitializeComponent();
            this.DataContext = this;

            TextBoxMin.Text = "Min";
            TextBoxMin.Foreground = Brushes.Gray;
            TextBoxMax.Text = "Max";
            TextBoxMax.Foreground = Brushes.Gray;

            medicineController = new MedicineController();
            RefusedMedicineList = new List<Medicine>();
            RejectedMedicines = new ObservableCollection<Medicine>();

            RefusedMedicineList = medicineController.GetAllRejectedMedicines();

            foreach (Medicine m in RefusedMedicineList)
            {
                RejectedMedicines.Add(m);
            }

            dataGridMedicines.ItemsSource = RejectedMedicines;
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var comboBoxSearchName = ComboBoxSearch.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (comboBoxSearchName.Equals("Medicine id"))
            {
                var resultList = RejectedMedicines.Where(medicine => medicine.MedicineId.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList;
                return;
            }
            if (comboBoxSearchName.Equals("Medicine name"))
            {
                var resultList = RejectedMedicines.Where(medicine => medicine.MedicineName.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Manufacturer"))
            {
                var resultList = RejectedMedicines.Where(medicine => medicine.Manufacturer.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Price range"))
            {
                return;

            }
            if (comboBoxSearchName.Equals("Quantity"))
            {
                var resultList = RejectedMedicines.Where(medicine => medicine.Quantity.ToString().Contains(TextBoxSearch.Text));
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
                RefusedMedicineList.Sort((x, y) => x.MedicineName.CompareTo(y.MedicineName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Price"))
            {
                RefusedMedicineList.Sort((x, y) => x.Price.CompareTo(y.Price));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Quantity in stock"))
            {
                RefusedMedicineList.Sort((x, y) => x.QuantityInStock.CompareTo(y.QuantityInStock));
                SortListToObsCollection();
                return;
            }
        }

        public void SortListToObsCollection()
        {
            ObservableCollection<Medicine> sortedMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine k in RefusedMedicineList)
            {
                sortedMedicines.Add(k);
            }
            RejectedMedicines = sortedMedicines;
            dataGridMedicines.ItemsSource = RejectedMedicines;
        }

        private void SearchByPrice(object sender, RoutedEventArgs e)
        {
            var resultMin = string.IsNullOrEmpty(this.TextBoxMin.Text) ? 0.0 : Double.Parse(this.TextBoxMin.Text);
            var resultMax = string.IsNullOrEmpty(this.TextBoxMax.Text) ? 0.0 : Double.Parse(this.TextBoxMax.Text);

            List<Medicine> medicinePriceList = new List<Medicine>();
            medicinePriceList = medicineController.GetPricesOfRejectedMedicines(resultMin, resultMax);

            RejectedMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine m in medicinePriceList)
            {
                RejectedMedicines.Add(m);
            }
            dataGridMedicines.ItemsSource = RejectedMedicines;

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


        private void RejectedButton(object sender, RoutedEventArgs e)
        {
            Window win = new ViewReasonForRejection(rm);
            win.ShowDialog();

        }
        private void ToMedicinesPendingApproval(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MedicinesPendingApprovalPharmacist.xaml", UriKind.Relative));

        }

        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PharmacistHome.xaml", UriKind.Relative));

        }

        private void IngredientsButton(object sender, RoutedEventArgs e)
        {
            Window win = new Ingredients();
            win.ShowDialog();
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
