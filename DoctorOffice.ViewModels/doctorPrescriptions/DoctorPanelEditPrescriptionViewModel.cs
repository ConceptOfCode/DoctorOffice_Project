using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class DoctorPanelEditPrescriptionViewModel
    {
        public int doctorPrescriptionID { get; set; }
        public int medicineID { get; set; }
        public int howUsesID { get; set; }
        public int turnsID { get; set; }
        public string patientFullName { get; set; }
        public int patientNationalID { get; set; }
        public string doctorFullName { get; set; }
        public string medicineName { get; set; }
        public string howUsesFullText { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
    }
}
