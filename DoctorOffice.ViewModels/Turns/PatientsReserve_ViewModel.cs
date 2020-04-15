using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class PatientsReserve_ViewModel
    {
        public int PatientID { get; set; }
        public string PatientsFullName { get; set; }
        public int nationalNumber { get; set; }
        public string reserveDate { get; set; }
        public int employeeID { get; set; }
        public string Description { get; set; }
    }
}
