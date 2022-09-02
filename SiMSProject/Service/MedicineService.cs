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
        private MedicineRepository medicineStorage;
        private UserRepository userStorage;

        public MedicineService()
        {
            medicineStorage = new MedicineRepository();
            userStorage = new UserRepository();
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

        public List<Medicine> GetPricesOfAcceptedMedicines(double min, double max)
        {
            return GetAllAcceptedMedicines().Where(x => x.Price >= min && x.Price <= max).ToList();
        }
        public List<Medicine> GetPricesOfRejectedMedicines(double min, double max)
        {
            return GetAllRejectedMedicines().Where(x => x.Price >= min && x.Price <= max).ToList();
        }
        public List<Medicine> GetPricesOfPendingApprovalMedicines(double min, double max)
        {
            return GetAllPendingApprovalMedicines().Where(x => x.Price >= min && x.Price <= max).ToList();

        }
        
        public bool CheckIfMedicineAcceptedByYou(User u, Medicine m)
        {
            foreach (User user in m.AcceptedByUsers)
            {
                if (user.Umcn.Equals(u.Umcn))
                {
                   
                    return true;
                }
            }
            return false;
        }

        public bool IsMedicineAcceptedByRelevantUsers(Medicine m)
        {
            int countDoctors = m.AcceptedByUsers.Where(x => x.UserType.ToString().Equals("Doctor")).ToList().Count();
            int countPharmacists = m.AcceptedByUsers.Where(x => x.UserType.ToString().Equals("Pharmacist")).ToList().Count();


            if (countDoctors >= 1 && countPharmacists >= 2)
            {
                m.MedicineStatus = MedicineStatusEnum.Accepted;
                Update(m);

                return true;
            }

            return false;
        }

        public DateTime? MedicineProcurement(int quantity, string date, Medicine medicine)
        {
            DateTime dateOfProcurement;
            if (string.IsNullOrEmpty(date))
            {
                medicine.Quantity += quantity;
                Update(medicine);
                return null;
            }
            else
            {
                return dateOfProcurement = Convert.ToDateTime(date);
            }
          
        
        }

        public bool CheckProcurementDate(DateTime dateOfProcurement, Medicine medicine, int quantity)
        {
            if (dateOfProcurement < DateTime.Now)
            {
                medicine.Quantity += quantity;
                Update(medicine);
                return true;
            }
            return false;
        }

    }
}