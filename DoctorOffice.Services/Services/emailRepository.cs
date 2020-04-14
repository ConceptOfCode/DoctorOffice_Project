using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class emailRepository : IEmailRepository
    {
        ProjectContext db;
        public emailRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Email>> getAllEmail()
        {
            return await Task.Run(() => db.Emails);
        }

        public async Task<Email> getEmailById(int id)
        {
            return await db.Emails.FindAsync(id);
        }

        public async Task<bool> insertEmail(Email email)
        {
            try
            {
                await db.Emails.AddAsync(email);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editEmail(Email email)
        {
            try
            {
                await Task.Run(() => db.Entry(email).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteEmail(Email email)
        {
            try
            {
                await Task.Run(() => db.Entry(email).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteEmail(int id)
        {
            try
            {
                Email find = await getEmailById(id);
                await deleteEmail(find);
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
