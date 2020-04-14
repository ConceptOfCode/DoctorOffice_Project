using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class DoctorPanelPrescriptionListViewModel
    {
        public int PrescriptionsID { get; set; }
        public int turnsID { get; set; }
        public string patientFullName { get; set; }
        public string temporaryPatientFullName{ get; set; }
        public int? PatientNationalID { get; set; }
        public int? temporaryPatientNationalID { get; set; }
        public string createDateTime { get; set; }
        public string doctorFullNasme { get; set; }
    }
}
