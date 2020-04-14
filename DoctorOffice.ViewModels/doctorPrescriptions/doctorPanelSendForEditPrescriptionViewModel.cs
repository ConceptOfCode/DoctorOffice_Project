using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
   public class doctorPanelSendForEditPrescriptionViewModel
    {
        public int prescriptionID { get; set; }
        public int medicineID { get; set; }
        public int howUseID { get; set; }
        public int turnsID { get; set; }
        public string medicineName { get; set; }
        public string howUseText { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
    }
}
