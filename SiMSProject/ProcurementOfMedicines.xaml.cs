using Model;
using SiMSProject.Controller;
using System;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;

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
        private Timer aTimer;
        private int quantity { get; set; }
        private DateTime dateOfProcurement { get; set; }

        public ProcurementOfMedicines(Medicine medicine)
        {
            InitializeComponent();
            medicineProcurement = new Medicine();
            medicineProcurement = medicine;
            medicineController = new MedicineController();

            this.medicineIdTextBox.Text = medicine.MedicineId;
            this.medicineNameTextBox.Text = medicine.MedicineName;

        }

        private void startTimer()
        {
            //60*2*1000 - two minutes - for testing
            //60*60*1000 - one hour
            //60*60*24*1000 - one day
            aTimer = new Timer(10000);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Start();
        }


        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

            if (dateOfProcurement < DateTime.Now)
            {
                medicineProcurement.Quantity += quantity;
                medicineController.Update(medicineProcurement);
                aTimer.Stop();
            }
        }

        private void ClickToProcurement(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.quantityTextBox.Text))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }

            quantity = Int32.Parse(this.quantityTextBox.Text);
            
            if (string.IsNullOrEmpty(this.DateTextBox.Text))
            {
                medicineProcurement.Quantity += quantity;
                medicineController.Update(medicineProcurement);
            } else {
                dateOfProcurement = Convert.ToDateTime(this.DateTextBox.Text);
                Console.WriteLine(this.DateTextBox.Text);
                startTimer();
            }
            
            this.Hide();
        }
    }
}
