﻿using Model;
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
        public List<Medicine> GetAllAcceptedMedicines()
        {
            return medicineService.GetAllAcceptedMedicines();
        }
        public List<Medicine> GetAllRejectedMedicines()
        {
            return medicineService.GetAllRejectedMedicines();
        }
        public List<Medicine> GetAllPendingApprovalMedicines()
        {
            return medicineService.GetAllPendingApprovalMedicines();
        }
        public Medicine CreateMedicine(Medicine medicine)
        {
            return medicineService.CreateMedicine(medicine);

        }
        public bool Update(Medicine medicine)
        {
            return medicineService.Update(medicine);
        }
        public void RejectedMedicines(Medicine medicine)
        {
            medicineService.RejectedMedicines(medicine);
        }
        public List<Medicine> GetPricesOfAcceptedMedicines(double min, double max)
        {
            return medicineService.GetPricesOfAcceptedMedicines(min, max);
        }
        public List<Medicine> GetPricesOfRejectedMedicines(double min, double max)
        {
            return medicineService.GetPricesOfRejectedMedicines(min, max);
        }
        public List<Medicine> GetPricesOfPendingApprovalMedicines(double min, double max)
        {
            return medicineService.GetPricesOfPendingApprovalMedicines(min, max);
        }

        public bool CheckIfMedicineAcceptedByYou(User u, Medicine m)
        {
            return medicineService.CheckIfMedicineAcceptedByYou(u, m);
        }

        public bool IsMedicineAcceptedByRelevantUsers(Medicine m)
        {
            return medicineService.IsMedicineAcceptedByRelevantUsers(m);
        }

        public DateTime? MedicineProcurement(int quantity, string date, Medicine medicine)
        {
            return medicineService.MedicineProcurement(quantity, date, medicine);
        }


        public bool CheckProcurementDate(DateTime dateOfProcurement, Medicine medicine, int quantity)
        {
            return medicineService.CheckProcurementDate(dateOfProcurement, medicine, quantity);
        }

    }
}
