using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class clinicOpeningHours
    {
        public clinicOpeningHours()
        {

        }

        [Key]
        public int clinicOpeningHoursID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public int clinicSpecificationsID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="روز هفته")]
        [MaxLength(100)]
        public string weekDay { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "ساعت شروع کار")]
        [MaxLength(50)]
        public string startTime { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "ساعت پایان کار")]
        [MaxLength(50)]
        public string endTime { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "این ساعات فعال باشد")]
        public bool isActive { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }


        public virtual clinicSpecifications clinicSpecifications { get; set; }
    }
}
