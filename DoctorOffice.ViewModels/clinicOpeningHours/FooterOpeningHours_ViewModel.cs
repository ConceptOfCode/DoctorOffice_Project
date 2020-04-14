using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class FooterOpeningHours_ViewModel
    {
        public string weekDays { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public bool isActive { get; set; }
    }
}
