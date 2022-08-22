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
            var medicineId = this.medicineId.Text;
            var medicineName = this.medicineName.Text;
            var manufacturer = this.manufacturer.Text;
            //var ingredients = this.ingredients.Text;
            var quantity = this.quantity.Text;
            var quantityInStock = this.quantityInStock.Text;
            var price = this.price.Text;
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
            medicine.Quantity = Int32.Parse(quantity);
            medicine.QuantityInStock = Int32.Parse(quantityInStock);
            double price1 = Double.Parse(price);
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

            if(createdMedicine == null)
            {
                System.Windows.MessageBox.Show("This medicine already exist!");
                return;
            }
            medicineController.Add(createdMedicine);
            System.Windows.MessageBox.Show("The medicine is pending approval.");
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
