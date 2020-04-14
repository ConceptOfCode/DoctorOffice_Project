using System;
using System.Collections.Generic;
using System.Text;
using DoctorOffice.Domains;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
   public interface IPaymentsRepository : IDisposable
    {
        Task<IEnumerable<Payment>> getAllPayment();

        Task<Payment> getPaymentById(int id);

        Task<bool> insertPayment(Payment payment);

        Task<bool> editPayment(Payment payment);

        Task<bool> deletePayment(Payment payment);

        Task<bool> deletePayment(int id);

        void saveChanges();
    }
}
