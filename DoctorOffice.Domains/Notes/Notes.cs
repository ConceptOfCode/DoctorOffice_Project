using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Notes : IDisposable
    {
        public Notes()
        {

        }

        [Key]
        public int noteID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="شناسه نوبت")]
        public int turnsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "عنوان یاداشت")]
        [MaxLength(150)]
        public string titleNote { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "متن کامل یاداشت")]
        public string fullTextNote { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ایجاد رکورد")]
        [MaxLength(10)]
        public string createDate { get; set; }


        public virtual Turns Turns { get; set; }

        public void Dispose()
        {
            
        }
    }
}
