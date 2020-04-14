using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Email
    {
        public Email()
        {

        }

        [Key]
        public int emailID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شناسه نوبت")]
        public int turnsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "عنوان ایمل")]
        [MaxLength(200)]
        public string TitleEmail { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "قالب ایمیل")]
        [MaxLength(400)]
        public string formatEmail { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "متن کامل ایمیل")]
        [MaxLength(5000)]
        public string fullTextEmail { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }



        public virtual Turns Turns { get; set; }
    }
}
