using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ViewModels
{
    public class MemoriesInformation_ViewModel
    {
        public int memoriesID { get; set; }
        public int patientsID { get; set; }
        public string fullNamePatient { get; set; }
        public int PatientsNationalNumber { get; set; }
        public string memoriesTitle { get; set; }
        public string memoriesFullText { get; set; }
        public string createDateTime { get; set; }
        public int likeCount { get; set; }
    }
}
