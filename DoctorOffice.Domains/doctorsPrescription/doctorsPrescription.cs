using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class doctorsPrescription : IDisposable
    {
        public doctorsPrescription()
        {

        }

        [Key]
        public int doctorsPrescriptionID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شناسه نوبت")]
        public int turnsID { get; set; }

        //[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[Display(Name = "شناسه دکتر")]
        //public int employeeID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ صدور")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "وضعیت نسخه")]
        public int prescriptionStatus { get; set; }

        [Display(Name = "توضیحات تکمیلی")]
        public string PrescriptionDescriptions { get; set; }


        public virtual Turns Turns { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set; }

        public void Dispose()
        {
            
        }
    }
}
