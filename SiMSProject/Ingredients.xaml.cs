using Model;
using SiMSProject.Controller;
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

namespace SiMSProject
{
    /// <summary>
    /// Interaction logic for Ingredients.xaml
    /// </summary>
    public partial class Ingredients : Window
    {
        private Medicine medicine { get; set; }
        private MedicineController medicineController;
        public Ingredients(Medicine m)
        {
            InitializeComponent();
            medicineController = new MedicineController();
            medicine = m;
        }

        private void ToOk(object sender, RoutedEventArgs e)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.IngredientName = string.IsNullOrEmpty(nameTextBox.Text) ? "" : nameTextBox.Text;
            ingredient.IngredientDescription = string.IsNullOrEmpty(descriptionTextBox.Text) ? "" : descriptionTextBox.Text;

            if (string.IsNullOrEmpty(ingredient.IngredientName) || string.IsNullOrEmpty(ingredient.IngredientDescription))
            {
                return;
            }

            var med = medicineController.CreateMedicine(medicine);
            if (med?.Ingredients.Count < 1)
            {
                medicine.Ingredients.Add(ingredient.IngredientName, ingredient);
                medicineController.Add(medicine);

            }else
            {
                medicine.Ingredients.Add(ingredient.IngredientName, ingredient);
                medicineController.Update(medicine);
            }
            this.Hide();

        }
    }
}
