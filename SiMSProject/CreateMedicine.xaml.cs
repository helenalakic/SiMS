using Model;
using SiMSProject.Controller;
using SiMSProject.Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CreateMedicine.xaml
    /// </summary>
    public partial class CreateMedicine : Page
    {
        private MedicineController medicineController;
        public CreateMedicine()
        {
            InitializeComponent();
            medicineController = new MedicineController();
        }

        private void ClickToCreateMedicine(object sender, RoutedEventArgs e)
        {
            var medicineId = this.medicineIdTextBox.Text;
            var medicineName = this.medicineNameTextBox.Text;
            var manufacturer = this.manufacturerTextBox.Text;
            //var ingredients = this.ingredients.Text;
            var quantity = this.quantityTextBox.Text;
            var quantityInStock = this.quantityInStockTextBox.Text;
            var price = this.priceTextBox.Text;
            Console.WriteLine(medicineId);
            Console.WriteLine(medicineName);
            Console.WriteLine(quantity);
            Console.WriteLine(manufacturer);
            Console.WriteLine(quantityInStock);
            Console.WriteLine(price);

            Medicine medicine = new Medicine();
            medicine.MedicineId = medicineId.ToString();
            medicine.MedicineName = medicineName.ToString();
            medicine.Manufacturer = manufacturer.ToString();
            medicine.Quantity = string.IsNullOrEmpty(quantity) ? 0 : Int32.Parse(quantity);
            medicine.QuantityInStock = string.IsNullOrEmpty(quantityInStock) ? 0 : Int32.Parse(quantityInStock);
            double price1 = string.IsNullOrEmpty(price) ? 0.0 : Double.Parse(price);
            medicine.Price = price1;
            // medicine.Ingredients = ingredients;

            Console.WriteLine(medicine.MedicineId);
            Console.WriteLine(medicine.MedicineName);
            Console.WriteLine(medicine.Manufacturer);
            Console.WriteLine(medicine.Quantity);
            Console.WriteLine(medicine.QuantityInStock);
            Console.WriteLine(medicine.Price);


            Medicine createdMedicine = new Medicine();
            createdMedicine = medicineController.CreateMedicine(medicine);

            var fieldsEmpty = false;

            if (medicineIdTextBox.Text == "" || medicineNameTextBox.Text == "" || manufacturerTextBox.Text == "" || quantityTextBox.Text == "" ||
                 quantityInStockTextBox.Text == "" || priceTextBox.Text == "" || medicineIdTextBox.Text == null || medicineNameTextBox.Text == null ||
                 manufacturerTextBox.Text == null || quantityTextBox.Text == null || quantityInStockTextBox.Text == null || priceTextBox.Text == null)
            {
                System.Windows.MessageBox.Show("Fields cannot be empty!");
                fieldsEmpty = true;
                return;
            }
            if (createdMedicine == null)
            {
                System.Windows.MessageBox.Show("This medicine already exist!");
                return;
            }
            if(!fieldsEmpty && createdMedicine != null)
            {
                medicineController.Add(createdMedicine);
                System.Windows.MessageBox.Show("The medicine is pending approval.");
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
        private void ToMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ManagerHome.xaml", UriKind.Relative));

        }
        private void ToAllUsers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AllUsers.xaml", UriKind.Relative));

        }

        private void ToRegistration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration.xaml", UriKind.Relative));

        }
    }
}
