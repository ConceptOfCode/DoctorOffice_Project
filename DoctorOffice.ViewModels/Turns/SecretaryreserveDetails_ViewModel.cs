using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
   public class SecretaryreserveDetails_ViewModel
    {
        public int turnsID { get; set; }
        public string fullNamePatient { get; set; }
        public int nationalNumber { get; set; }
        public string fatherName { get; set; }
        public string birthDate { get; set; }
        public int phoneNumber { get; set; }
        public string Email { get; set; }
        public string reserveDate { get; set; }
        public string currentDate { get; set; }
    }
}
