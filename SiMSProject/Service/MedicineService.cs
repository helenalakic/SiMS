using Model;
using SiMSProject.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Service
{
    public class MedicineService
    {
        private MedicineStorage medicineStorage;

        public MedicineService()
        {
            medicineStorage = new MedicineStorage();
        }

        public void Add(Medicine medicine)
        {
            medicineStorage.Create(medicine);
        }

        public List<Medicine> GetAllMedicines()
        {
            return medicineStorage.GetAllMedicines();
        }

    }
}
