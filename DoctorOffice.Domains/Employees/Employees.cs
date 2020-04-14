using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
   public class Employees
    {
        public Employees()
        {

        }

        [Key]
        public int employeeID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(80)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        [MaxLength(180)]
        public string lastName { get; set; }

        [Display(Name = "نام پدر")]
        [MaxLength(80)]
        public string fatherName { get; set; }

        [Display(Name = "شماره ملی")]
        public int nationalNumber { get; set; }

        [Display(Name = "تاریخ تولد")]
        [MaxLength(10)]
        public string birthDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ایجاد")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Display(Name = "تصویر")]
        public string imageName { get; set; }

        [Display(Name = "شماره تلفن")]
        public int phoneNumber { get; set; }

        [EmailAddress]
        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="نوع پرسنل")]
        public int Type { get; set; }


        public virtual ICollection<Turns> Turns { get; set; }
    }
}
