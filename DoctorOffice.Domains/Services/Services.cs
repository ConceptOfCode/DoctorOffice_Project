using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Domains
{
    public class Services
    {
        [Key]
        public int ServicesID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="عنوان")]
        [MaxLength(80)]
        public string Title { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="توضیح درباره خدمات")]
        [MaxLength(160)]
        public string fullTextServices { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="نمایش داده شود؟")]
        public bool showInPage { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="ترتیب")]
        public int Order { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="تاریخ ثبت")]
        [MaxLength(19)]
        public string createDateTime { get; set; }
    }
}
