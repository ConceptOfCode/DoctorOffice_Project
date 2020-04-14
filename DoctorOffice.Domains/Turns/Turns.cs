using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoctorOffice.Domains
{
    public class Turns
    {
        public Turns()
        {

        }

        [Key]
        public int turnsID { get; set; }

        [Display(Name = "شناسه مریض")]
        public int? patientsID { get; set; }

        [Display(Name = "شناسه مریض موقت")]
        public int? temporaryPatientsID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شناسه دکتر")]
        [ForeignKey("Employees")]
        public int employeeID { get; set; }

        //[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[Display(Name = "شناسه نحوه پرداخت")]
        //public int PaymentID { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ رزرو")]
        [MaxLength(10)]
        public string reserveDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ ثبت رکورد")]
        [MaxLength(10)]
        public string createDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "وضعیت نوبت")]
        public int statusTurn { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(300)]
        public string Descriptions { get; set; }


        public virtual patients Patients { get; set; }
        public virtual Temporarypatients temporaryPatients { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ICollection<SMS> SMS { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Notes> Notes { get; set; }
        public virtual ICollection<doctorsPrescription> DoctosPrescriptions { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
