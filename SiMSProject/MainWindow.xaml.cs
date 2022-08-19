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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController UserController;
        private MedicineController MedicineController;

        public MainWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();
            MainFrame.NavigationService.Navigate(loginPage);

            //MedicineController = new MedicineController();

            //Medicine medicine = new Medicine();
            //medicine.MedicineId = "5a";
            //medicine.MedicineName = "rapten";
            //medicine.Manufacturer = "galen";
            //medicine.Quantity = 10;
            //medicine.QuantityInStock = 50;
            //medicine.Price = 1000;
            //medicine.MedicineStatus = MedicineStatusEnum.Accepted;

            //Medicine medicine1 = new Medicine();
            //medicine1.MedicineId = "7b";
            //medicine1.MedicineName = "brufen";
            //medicine1.Manufacturer = "pharm";
            //medicine1.Quantity = 70;
            //medicine1.QuantityInStock = 20;
            //medicine1.Price = 200;
            //medicine1.MedicineStatus = MedicineStatusEnum.PendingApproval;


            //Medicine medicine2 = new Medicine();
            //medicine2.MedicineId = "1p";
            //medicine2.MedicineName = "paracetamol";
            //medicine2.Manufacturer = "galen";
            //medicine2.Quantity = 2;
            //medicine2.QuantityInStock = 40;
            //medicine2.Price = 3500;
            //medicine2.MedicineStatus = MedicineStatusEnum.Rejected;


            //MedicineController.Add(medicine);
            //MedicineController.Add(medicine1);
            //MedicineController.Add(medicine2);


            // za prvi put zbog upisa u datoteku
            // UserController = new UserController();
            //User user = new User();
            //user.UMCN = "123";
            //user.EMAIL = "hela";
            //user.PASSWORD = "1";
            //user.FIRSTNAME = "helena";
            //user.LASTNAME = "lakic";
            //user.PHONENUMBER = "555";
            //user.USERTYPE = UserType.Doctor;

            //User user1 = new User();
            //user1.UMCN = "222";
            //user1.EMAIL = "maga";
            //user1.PASSWORD = "2";
            //user1.FIRSTNAME = "magdalena";
            //user1.LASTNAME = "lakic";
            //user1.PHONENUMBER = "333";
            //user1.USERTYPE = UserType.Pharmacist;

            //User user2 = new User();
            //user2.UMCN = "444";
            //user2.EMAIL = "boka";
            //user2.PASSWORD = "3";
            //user2.FIRSTNAME = "bojana";
            //user2.LASTNAME = "zekanovic";
            //user2.PHONENUMBER = "777";
            //user2.USERTYPE = UserType.Pharmacist;

            //User user3 = new User();
            //user3.UMCN = "999";
            //user3.EMAIL = "vanja";
            //user3.PASSWORD = "4";
            //user3.FIRSTNAME = "vanja";
            //user3.LASTNAME = "teodorovic";
            //user3.PHONENUMBER = "11";
            //user3.USERTYPE = UserType.Manager;

            //UserController.Add(user);
            //UserController.Add(user1);
            //UserController.Add(user2);
            //UserController.Add(user3);


        }

    }
}
