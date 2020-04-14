using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoctorOffice.Domains
{
    public class constantConcepts
    {
        public constantConcepts()
        {

        }

        [Key]
        public int constantConceptsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "عنوان")]
        [MaxLength(200)]
        public string Title { get; set; }

        [Display(Name = "فعال است؟")]
        [ForeignKey("constantConceptsID")]
        public int isActive { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDateTime { get; set; }

        public virtual List<constantConcepts> ConstantConcepts { get; set; }
    }
}
