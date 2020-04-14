using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class paymentRepository : IPaymentsRepository
    {
        ProjectContext db;
        public paymentRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Payment>> getAllPayment()
        {
            return await Task.Run(() => db.Payments);
        }

        public async Task<Payment> getPaymentById(int id)
        {
            return await db.Payments.FindAsync(id);
        }

        public async Task<bool> insertPayment(Payment payment)
        {
            try
            {
                await db.Payments.AddAsync(payment);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editPayment(Payment payment)
        {
            try
            {
                await Task.Run(() => db.Entry(payment).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletePayment(Payment payment)
        {
            try
            {
                await Task.Run(() => db.Entry(payment).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletePayment(int id)
        {
            try
            {
                Payment find = await getPaymentById(id);
                await deletePayment(find);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async void saveChanges()
        {
            await db.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await db.DisposeAsync();
        }
    }
}
