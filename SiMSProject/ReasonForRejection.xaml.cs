using Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Windows.Forms;
using SiMSProject.Controller;
using System.Collections.ObjectModel;
using SiMSProject.Model;

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

        public ReasonForRejection(Medicine medicine)
        {
            InitializeComponent();
            medicineController = new MedicineController();
            PendingApprovalMedicineList = new List<Medicine>();
            PendingApprovalMedicines = new ObservableCollection<Medicine>();
            declineMedicine = new Medicine();
            declineMedicine = medicine;
            
        }

        private void ClickToRejection(object sender, RoutedEventArgs e)
        {
            declineMedicine.MedicineStatus = MedicineStatusEnum.Rejected;
            medicineController.Update(declineMedicine);
            this.Hide();

        }
    }
}
