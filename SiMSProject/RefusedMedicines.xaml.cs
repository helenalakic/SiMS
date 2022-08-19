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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for RefusedMedicines.xaml
    /// </summary>
    public partial class RefusedMedicines : Page
    {
        private MedicineController medicineController;
        private List<Medicine> RefusedMedicineList { get; set; }
        private ObservableCollection<Medicine> RejectedMedicines { get; set; }
        public RefusedMedicines()
        {
            InitializeComponent();
            this.DataContext = this;

            medicineController = new MedicineController();
            RefusedMedicineList = new List<Medicine>();
            RejectedMedicines = new ObservableCollection<Medicine>();

            RefusedMedicineList = medicineController.GetAllRejectedMedicines();

            foreach (Medicine m in RefusedMedicineList)
            {
                RejectedMedicines.Add(m);
            }

            dataGridMedicines.ItemsSource = RejectedMedicines;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {

        }

        private void SortBy(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RejectedButton(object sender, RoutedEventArgs e)
        {

        }
        private void MedicinesPendingApproval(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MedicinesPendingApprovalPharmacist.xaml", UriKind.Relative));

        }

        private void AcceptedMedicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AcceptedMedicines.xaml", UriKind.Relative));

        }

        private void Medicines(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PharmacistHome.xaml", UriKind.Relative));

        }
    }
}
