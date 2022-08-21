// File:    Medicine.cs
// Author:  Helena Lakic
// Created: Sunday, July 24, 2022 16:51:48 
// Purpose: Definition of Class Medicine

using SiMSProject.Model;
using SiMSProject.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public class Medicine :  Serializable
    {
        public String MedicineId { get; set; }
        public String MedicineName { get; set; }
        public String Manufacturer { get; set; }
        public int Quantity { get; set; }
        public IDictionary<string, Ingredient> Ingredients { get; set; }
        public MedicineStatusEnum MedicineStatus { get; set; } = MedicineStatusEnum.PendingApproval;
        public bool Deleted { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }


        public void fromCSV(string[] values)
        {
            MedicineId = values[0];
            MedicineName = values[1];
            Manufacturer = values[2];
            Quantity = Int32.Parse(values[3]);
            QuantityInStock = Int32.Parse(values[4]);
            Price = Double.Parse(values[5]);
            MedicineStatus = (MedicineStatusEnum)Enum.Parse(typeof(MedicineStatusEnum), values[6]);



            //var ingredientsString = values[4].Split(',');
            //var ingredientsKey = ingredientsString[0];
            //var ingredientsValue = ingredientsString[1];
            //Ingredients.Add(values[4], new Ingredient(values[4], ));
        }

        public string[] toCSV()
        {
            string[] medicine =
            {
                MedicineId,
                MedicineName,
                Manufacturer,
                Quantity.ToString(),
                QuantityInStock.ToString(),
                Price.ToString(),
                Enum.GetName(MedicineStatus.GetType(), MedicineStatus),

               // ingredient.ingredientName,
            };
            return medicine;
        }

       

    }
}