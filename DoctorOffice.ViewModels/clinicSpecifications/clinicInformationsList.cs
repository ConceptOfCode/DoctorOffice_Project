using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class clinicInformationsList
    {
        public int clinicSpecificationsID { get; set; }
        public string shortAddress { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public bool isActive { get; set; }
    }
}
