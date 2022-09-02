using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Storage
{
    public class MedicineRepository
    {

        private string fileName = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\SiMSProject\Resources\Data\MedicineStorage.csv";
        private Serializer<Medicine> medicineSerializer = new();

        public MedicineRepository()
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine(fileName);
                File.Create(fileName).Close();
            }
        }

        public bool Create(Medicine medicine)
        {
            List<Medicine> medicines = new List<Medicine>();

            medicines = medicineSerializer.fromCSV(fileName);
            foreach (Medicine m in medicines)
            {
                if (medicine.MedicineId == m.MedicineId)
                    return false;
            }

            medicines.Add(medicine);
            medicineSerializer.toCSV(fileName, medicines);
            return true;
        }
        public bool Update(Medicine medicine)
        {
            List<Medicine> allMedicines = medicineSerializer.fromCSV(fileName);
            int foundIndex = -1;
            foreach (Medicine m in allMedicines)
            {
                if (medicine.MedicineId == m.MedicineId)
                    foundIndex = allMedicines.IndexOf(m);
            }
            allMedicines.RemoveAt(foundIndex);
            allMedicines.Insert(foundIndex, medicine);
            medicineSerializer.toCSV(fileName, allMedicines);
            return true;
        }

        public List<Medicine> GetAllMedicines()
        {
            return medicineSerializer.fromCSV(fileName);

        }

       
    }
}
