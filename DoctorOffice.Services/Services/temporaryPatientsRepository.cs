using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class temporaryPatientsRepository : ITemporaryPatientsRepository
    {
        ProjectContext db;   
        public temporaryPatientsRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Temporarypatients>> getAllTemporaryPatients()
        {
            return await Task.Run(()=> db.temporaryPatients);
        }

        public async Task<Temporarypatients> getTemporaryPatientsById(int id)
        {
            return await db.temporaryPatients.FindAsync(id);
        }

        public async Task<bool> insertTemporaryPatients(Temporarypatients temporaryPatients)
        {
            try
            {
                await db.temporaryPatients.AddAsync(temporaryPatients);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editTemporaryPatients(Temporarypatients temporaryPatients)
        {
            try
            {
                await Task.Run(() => db.Entry(temporaryPatients).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteTemporaryPatients(int id)
        {
            try
            {
                Temporarypatients find = await getTemporaryPatientsById(id);
                await deleteTemporaryPatients(find);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteTemporaryPatients(Temporarypatients temporaryPatients)
        {
            try
            {
                await Task.Run(() => db.Entry(temporaryPatients).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task saveChanges()
        {
            await db.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await db.DisposeAsync();
        }
    }
}
