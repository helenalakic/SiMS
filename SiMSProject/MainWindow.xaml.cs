using Model;
using SiMSProject.Controller;
using SiMSProject.Model;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows;


namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController UserController;
        private MedicineController MedicineController;
        private Timer aTimer;


        public User LoggedUser = new User();

        public MainWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();

            MainFrame.NavigationService.Navigate(loginPage);

          //  startTimer();


            // ************** USERS ************** 
            UserController = new UserController();
            User user = new User();
            user.Umcn = "123";
            user.Email = "hela@gmail.com";
            user.Password = "1";
            user.FirstName = "helena";
            user.LastName = "lakic";
            user.PhoneNumber = "555";
            user.UserType = UserTypeEnum.Doctor;
            user.IsBlocked = false;


            User user1 = new User();
            user1.Umcn = "222";
            user1.Email = "maga@gmail.com";
            user1.Password = "2";
            user1.FirstName = "magdalena";
            user1.LastName = "lakic";
            user1.PhoneNumber = "333";
            user1.UserType = UserTypeEnum.Pharmacist;
            user1.IsBlocked = false;

            User user2 = new User();
            user2.Umcn = "444";
            user2.Email = "boka@gmail.com";
            user2.Password = "3";
            user2.FirstName = "bojana";
            user2.LastName = "zekanovic";
            user2.PhoneNumber = "777";
            user2.UserType = UserTypeEnum.Pharmacist;
            user2.IsBlocked = false;

            User user3 = new User();
            user3.Umcn = "999";
            user3.Email = "vanja@gmail.com";
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


            // **************MEDICINES **************
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
            medicine.ReasonForRejection = "";

            Ingredient i = new Ingredient();
            i.IngredientName = "mg";
            i.IngredientDescription = "magnezijum";
            medicine.Ingredients.Add(i.IngredientName, i);

            Ingredient i2 = new Ingredient();
            i2.IngredientName = "ca";
            i2.IngredientDescription = "kalcijum";
            medicine.Ingredients.Add(i2.IngredientName, i2);


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
            medicine1.ReasonForRejection = "";
            medicine1.Ingredients = new Dictionary<string, Ingredient>();

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
            medicine2.ReasonForRejection = "Wrong manufacturer";
            medicine2.Ingredients.Add(i2.IngredientName, i2);

            //MedicineController.Add(medicine);
            //MedicineController.Add(medicine1);
            //MedicineController.Add(medicine2);



        }
    }
}
