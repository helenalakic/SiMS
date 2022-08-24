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
    /// Interaction logic for ProcurementOfMedicines.xaml
    /// </summary>
    public partial class ProcurementOfMedicines : Window
    {
        private MedicineController medicineController;
        private Medicine medicineProcurement;
        private ObservableCollection<Medicine> Medicines { get; set; }


        public ProcurementOfMedicines(Medicine medicine)
        {
            InitializeComponent();
            medicineProcurement = new Medicine();
            medicineProcurement = medicine;
            medicineController = new MedicineController();

            this.medicineIdTextBox.Text = medicine.MedicineId;
            this.medicineNameTextBox.Text = medicine.MedicineName;

        }

        private void ClickToProcurement(object sender, RoutedEventArgs e)
        {
            //TO DO null or empty
            if (quantityTextBox.Text == "" || quantityTextBox.Text == null)
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            var quantity = this.quantityTextBox.Text;
            medicineProcurement.Quantity = Int32.Parse(quantity);
            medicineController.Update(medicineProcurement);

            this.Hide();

        }
    }
}
