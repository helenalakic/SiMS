using Model;
using SiMSProject.Model;
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
        private UserStorage userStorage;

        public MedicineService()
        {
            medicineStorage = new MedicineStorage();
            userStorage = new UserStorage();
        }

        public void Add(Medicine medicine)
        {
            medicineStorage.Create(medicine);
        }

        public List<Medicine> GetAllMedicines()
        {
            return medicineStorage.GetAllMedicines();
        }

        public List<Medicine> GetAllAcceptedMedicines()
        {
            return medicineStorage.GetAllMedicines().Where(x => x.MedicineStatus == MedicineStatusEnum.Accepted).ToList();

        }
        public List<Medicine> GetAllRejectedMedicines()
        {
            return medicineStorage.GetAllMedicines().Where(x => x.MedicineStatus == MedicineStatusEnum.Rejected).ToList();
        }

        public List<Medicine> GetAllPendingApprovalMedicines()
        {
            return medicineStorage.GetAllMedicines().Where(x => x.MedicineStatus == MedicineStatusEnum.PendingApproval).ToList();
        }
       
       
        public Medicine CreateMedicine(Medicine medicine)
        {
            List<Medicine> medicines = new List<Medicine>();
            medicines = medicineStorage.GetAllMedicines();
            foreach (Medicine m in medicines)
            {
                if (m.MedicineId.Equals(medicine.MedicineId))
                {
                    return null;
                }
            }
            return medicine;
        }
        public bool Update(Medicine medicine)
        {
            return medicineStorage.Update(medicine);
        }
        public void RejectedMedicines(Medicine medicine)
        {
            medicine.MedicineStatus = MedicineStatusEnum.Rejected;
            medicineStorage.Update(medicine);
        }

        
    }
}