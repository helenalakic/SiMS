using Model;
using System.Collections.Generic;
using System.Windows;
using SiMSProject.Controller;
using System.Collections.ObjectModel;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for ReasonForRejection.xaml
    /// </summary>
    public partial class ReasonForRejection : Window
    {
        private MedicineController medicineController;
        private List<Medicine> PendingApprovalMedicineList { get; set; }
        private ObservableCollection<Medicine> PendingApprovalMedicines { get; set; }
        private Medicine declineMedicine;
        private User userDeclined { get; set; }

        public ReasonForRejection(Medicine medicine, User user)
        {
            InitializeComponent();
            medicineController = new MedicineController();
            PendingApprovalMedicineList = new List<Medicine>();
            PendingApprovalMedicines = new ObservableCollection<Medicine>();

            declineMedicine = new Medicine();
            declineMedicine = medicine;

            userDeclined = new User();
            userDeclined = user;

            this.firstNameTextBox.Text = user.FirstName;
            this.lastNameTextBox.Text = user.LastName;
            this.userTypeTextBox.Text = user.UserType.ToString();
        }

        private void ClickToRejection(object sender, RoutedEventArgs e)
        {
            if (reasonTextBox.Text == "" || reasonTextBox.Text == null)
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }
            
            var reason = this.reasonTextBox.Text;
            declineMedicine.ReasonForRejection = reason;
            declineMedicine.DeclinedBy = userDeclined;

            medicineController.RejectedMedicines(declineMedicine);
            this.Hide();
            System.Windows.MessageBox.Show("The medicine has been rejected and is in rejected medicines.");
        }
    }
}
