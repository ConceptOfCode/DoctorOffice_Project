using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Memories
    {
        public Memories()
        {

        }

        [Key]
        public int MemoriesID { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public int patientsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "عنوان خاطره")]
        [MaxLength(100)]
        public string memoriesTitle { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "توضیح کامل خاطره")]
        [MaxLength(600)]
        public string fullTextMemories { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ایجاد")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Display(Name = "تعداد لایک ها")]
        public int likeCount { get; set; }


        public virtual patients Patients { get; set; }
    }
}
