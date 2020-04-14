using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class howUse : IDisposable
    {
        public howUse()
        {

        }

        [Key]
        public int howUseID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="شناسه دارو")]
        public int medicineID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "متن نحوه مصرف")]
        [MaxLength(1000)]
        public string howUseText { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "از تاریخ")]
        [MaxLength(10)]
        public string useFrom { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تا تاریخ")]
        [MaxLength(10)]
        public string useTo { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "توضیحات")]
        [MaxLength(300)]
        public string Descriptions { get; set; }


        public virtual Medicine Medicine { get; set; }

        public void Dispose()
        {
            
        }
    }
}
