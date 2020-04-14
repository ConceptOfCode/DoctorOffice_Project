using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Payment
    {
        public Payment()
        {

        }

        [Key]
        public int paymentsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شناسه نوبت")]
        public int turnsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نوع پرداخت")]
        public int typePayment { get; set; }

        [Display(Name = "مبلغ")]
        public decimal Price { get; set; }

        [Display(Name = "کدرهگیری")]
        public long trackingCode { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ پرداخت")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(300)]
        public string Descriptions { get; set; }


        public virtual Turns Turns { get; set; }
    }
}
