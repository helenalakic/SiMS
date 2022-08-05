using Model;
using SiMSProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Controller
{
    internal class MedicineController
    {
        private MedicineService medicineService;

        public MedicineController()
        {
            medicineService = new MedicineService();
        }

        public void Add(Medicine medicine)
        {
            medicineService.Add(medicine);
        }

        public List<Medicine> GetAllMedicines()
        {
            return medicineService.GetAllMedicines();
        }
    }
}
