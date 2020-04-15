using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class PatientReserveList_ViewModel
    {
        public int turnsID { get; set; }
        public string reserveDate { get; set; }
        public string currentDate { get; set; }
        public string doctorFullName { get; set; }
        public string PatientEmail { get; set; }
    }
}
