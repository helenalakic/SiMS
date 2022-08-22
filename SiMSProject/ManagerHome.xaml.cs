﻿using Model;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for ManagerHome.xaml
    /// </summary>
    public partial class ManagerHome : Page
    {
        public Frame _mainFrame;

        private MedicineController medicineController;
        private List<Medicine> MedicineList { get; set; }
        private ObservableCollection<Medicine> Medicines { get; set; }
       
        public ManagerHome()
        {
            InitializeComponent();
            this.DataContext = this;

            medicineController = new MedicineController();
            MedicineList = new List<Medicine>();
            Medicines = new ObservableCollection<Medicine>();

            MedicineList = medicineController.GetAllMedicines();

            foreach (Medicine k in MedicineList)
            {
                Medicines.Add(k);
            }

            dataGridMedicines.ItemsSource = Medicines;
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Sign out", MessageBoxButtons.YesNo)
                == (DialogResult)MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var comboBoxSearchName = ComboBoxSearch.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            if (comboBoxSearchName.Equals("Medicine id"))
            {
                var resultList = Medicines.Where(medicine => medicine.MedicineId.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList;
                return;
            }
            if (comboBoxSearchName.Equals("Medicine name"))
            {
                var resultList = Medicines.Where(medicine => medicine.MedicineName.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Manufacturer"))
            {
                var resultList = Medicines.Where(medicine => medicine.Manufacturer.ToLower().Contains(TextBoxSearch.Text.ToLower()));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Price range"))
            {
                //kod za pretragu
                return;

            }
            if (comboBoxSearchName.Equals("Quantity"))
            {
                var resultList = Medicines.Where(medicine => medicine.Quantity.ToString().Contains(TextBoxSearch.Text));
                dataGridMedicines.ItemsSource = resultList; return;
            }
            if (comboBoxSearchName.Equals("Ingredients"))
            {
                //kod za pretragu
                return;
            }
        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxSortName = ComboBoxSort.SelectedItem.ToString().Split(':')[1].TrimStart(' ');
            Console.WriteLine(ComboBoxSort.SelectedItem);

            if (comboBoxSortName.Equals("Medicine name"))
            {
                MedicineList.Sort((x, y) => x.MedicineName.CompareTo(y.MedicineName));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Price"))
            {
                MedicineList.Sort((x, y) => x.Price.CompareTo(y.Price));
                SortListToObsCollection();
                return;
            }

            if (comboBoxSortName.Equals("Quantity in stock"))
            {
                MedicineList.Sort((x, y) => x.QuantityInStock.CompareTo(y.QuantityInStock));
                SortListToObsCollection();
                return;
            }
        }

        public void SortListToObsCollection()
        {
            ObservableCollection<Medicine> sortedMedicines = new ObservableCollection<Medicine>();
            foreach (Medicine k in MedicineList)
            {
                sortedMedicines.Add(k);
            }
            Medicines = sortedMedicines;
            dataGridMedicines.ItemsSource = Medicines;
        }

        private void ToAllUsers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AllUsers.xaml", UriKind.Relative));

        }

        private void ProcurementButton(object sender, RoutedEventArgs e)
        {
            Window win = new ProcurementOfMedicines();
            win.ShowDialog();
        }

        private void ToRegistration(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration.xaml", UriKind.Relative));

        }

        private void ToCreateMedicine(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("CreateMedicine.xaml", UriKind.Relative));

        }

        private void IngredientsButton(object sender, RoutedEventArgs e)
        {
            Window win = new Ingredients();
            win.ShowDialog();
        }
    }
}

