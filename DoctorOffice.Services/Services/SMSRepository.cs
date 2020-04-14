using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class SMSRepository : ISmsRepository
    {
        ProjectContext db;
        public SMSRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<SMS>> getAllSMS()
        {
            return await Task.Run(() => db.SMS);
        }

        public async Task<SMS> getSMSById(int id)
        {
            return await db.SMS.FindAsync(id);
        }

        public async Task<bool> insertSMS(SMS SMS)
        {
            try
            {
                await db.SMS.AddAsync(SMS);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editSMS(SMS SMS)
        {
            try
            {
                await Task.Run(() => db.Entry(SMS).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteSMS(SMS SMS)
        {
            try
            {
                await Task.Run(() => db.Entry(SMS).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteSMS(int id)
        {
            try
            {
                SMS find = await getSMSById(id);
                await deleteSMS(find);
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
