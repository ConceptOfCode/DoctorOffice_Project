using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class HeaderInformationSite_ViewModel
    {
        public string fullAddress { get; set; }
        public string shortAddress { get; set; }
        public string clinicPhone { get; set; }
        public string currentDateTime { get; set; }
        public bool isActive { get; set; }
    }
}
