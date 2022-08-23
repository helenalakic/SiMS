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
using System.Windows.Shapes;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for ViewReasonForRejection.xaml
    /// </summary>
    public partial class ViewReasonForRejection : Window
    {
        public ViewReasonForRejection(Medicine medicine)
        {
            InitializeComponent();
           
            this.firstName.Text = medicine.DeclinedBy.FirstName;
            this.lastName.Text = medicine.DeclinedBy.LastName;
            this.userType.Text = medicine.DeclinedBy.UserType.ToString();
            this.reason.Text = medicine.ReasonForRejection;

        }

        private void ClickToCloseReason(object sender, RoutedEventArgs e)
        {
            this.Hide();

        }
    }
}
