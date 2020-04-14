using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class SMS
    {
        public SMS()
        {

        }

        [Key]
        public int smsID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="شناسه نوبت")]
        public int turnsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "عنوان پیام")]
        [MaxLength(200)]
        public string TitleSMS { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "قالب پیام")]
        [MaxLength(400)]
        public string formatSMS { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "متن کامل پیام")]
        [MaxLength(5000)]
        public string fullTextSMS { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }



        public virtual Turns Turns { get; set; }
    }
}
