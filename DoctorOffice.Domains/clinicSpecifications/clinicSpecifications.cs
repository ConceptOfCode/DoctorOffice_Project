using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class clinicSpecifications
    {
        public clinicSpecifications()
        {

        }

        [Key]
        public int clinicSpecificationsID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="نام خیابان")]
        [MaxLength(100)]
        public string streetName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام کشور")]
        [MaxLength(100)]
        public string countryName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام شهر")]
        [MaxLength(100)]
        public string cityName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شماره مطب")]
        [MaxLength(12)]
        public string clinicPhone { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شماره پلاک")]
        [MaxLength(3)]
        public string clinicPlack { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نشانی دقیق")]
        [MaxLength(500)]
        public string fullAddress { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "فعال بودن این مشخصات")]
        public bool isActive { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }



        public virtual ICollection<clinicOpeningHours> clinicOpeningHours { get; set; }
    }
}
