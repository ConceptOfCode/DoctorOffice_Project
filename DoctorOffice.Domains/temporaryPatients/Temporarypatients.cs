using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Temporarypatients
    {
        public Temporarypatients()
        {

        }

        [Key]
        public int temporaryPatientsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(80)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        [MaxLength(180)]
        public string lastName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام پدر")]
        [MaxLength(80)]
        public string fatherName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شماره ملی")]
        public int nationalNumber { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ تولد")]
        [MaxLength(10)]
        public string birthDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ایجاد")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Required(ErrorMessage = "برای ارسال پیامک لطفا {0} را وارد کنید")]
        [Display(Name = "شماره تلفن")]
        public int phoneNumber { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }


        public virtual ICollection<Turns> Turns { get; set; }
    }
}
