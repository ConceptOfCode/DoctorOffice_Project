using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class DoctorPanelNewPrescriptionInfoViewModel
    {
        public int turnsID { get; set; }
        public string patientFullName { get; set; }
        public int PatientNationalID { get; set; }
        public string doctorFullNane { get; set; }
    }
}
