using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Medicine : IDisposable
    {
        public Medicine()
        {

        }

        [Key]
        public int medicineID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شناسه نسخه")]
        public int doctorsPrescriptionID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام دارو")]
        [MaxLength(200)]
        public string medicineName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "توضیحات")]
        [MaxLength(300)]
        public string Descriptions { get; set; }


        public virtual doctorsPrescription DoctosPrescription { get; set; }
        public virtual ICollection<howUse> howUses { get; set; }

        public void Dispose()
        {
            
        }
    }
}
