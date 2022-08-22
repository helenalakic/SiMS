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

        public User LoggedUser = new User();

        public MainWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();

            MainFrame.NavigationService.Navigate(loginPage);



            // ************** USERS ************** 
            UserController = new UserController();
            User user = new User();
            user.Umcn = "123";
            user.Email = "hela";
            user.Password = "1";
            user.FirstName = "helena";
            user.LastName = "lakic";
            user.PhoneNumber = "555";
            user.UserType = UserTypeEnum.Doctor;
            user.IsBlocked = false;


            User user1 = new User();
            user1.Umcn = "222";
            user1.Email = "maga";
            user1.Password = "2";
            user1.FirstName = "magdalena";
            user1.LastName = "lakic";
            user1.PhoneNumber = "333";
            user1.UserType = UserTypeEnum.Pharmacist;
            user1.IsBlocked = false;

            User user2 = new User();
            user2.Umcn = "444";
            user2.Email = "boka";
            user2.Password = "3";
            user2.FirstName = "bojana";
            user2.LastName = "zekanovic";
            user2.PhoneNumber = "777";
            user2.UserType = UserTypeEnum.Pharmacist;
            user2.IsBlocked = false;

            User user3 = new User();
            user3.Umcn = "999";
            user3.Email = "vanja";
            user3.Password = "4";
            user3.FirstName = "vanja";
            user3.LastName = "teodorovic";
            user3.PhoneNumber = "11";
            user3.UserType = UserTypeEnum.Manager;
            user3.IsBlocked = false;

            //UserController.Add(user);
            //UserController.Add(user1);
            //UserController.Add(user2);
            //UserController.Add(user3);


           // **************MEDICINES * *************
            MedicineController = new MedicineController();
            Medicine medicine = new Medicine();
            medicine.MedicineId = "5a";
            medicine.MedicineName = "rapten";
            medicine.Manufacturer = "galen";
            medicine.Quantity = 10;
            medicine.QuantityInStock = 50;
            medicine.Price = 1000;
            medicine.MedicineStatus = MedicineStatusEnum.Accepted;
            medicine.AcceptedByUsers.Add(user);
            medicine.AcceptedByUsers.Add(user1);
            medicine.AcceptedByUsers.Add(user2);
            medicine.DeclinedBy = new User();

            Medicine medicine1 = new Medicine();
            medicine1.MedicineId = "7b";
            medicine1.MedicineName = "brufen";
            medicine1.Manufacturer = "pharm";
            medicine1.Quantity = 70;
            medicine1.QuantityInStock = 20;
            medicine1.Price = 200;
            medicine1.MedicineStatus = MedicineStatusEnum.PendingApproval;
            medicine1.AcceptedByUsers.Add(user);
            medicine1.DeclinedBy = new User();


            Medicine medicine2 = new Medicine();
            medicine2.MedicineId = "1p";
            medicine2.MedicineName = "paracetamol";
            medicine2.Manufacturer = "galen";
            medicine2.Quantity = 2;
            medicine2.QuantityInStock = 40;
            medicine2.Price = 3500;
            medicine2.MedicineStatus = MedicineStatusEnum.Rejected;
            medicine2.AcceptedByUsers = new List<User>();
            medicine2.DeclinedBy = user1;

            //MedicineController.Add(medicine);
            //MedicineController.Add(medicine1);
            //MedicineController.Add(medicine2);



        }

    }
}
