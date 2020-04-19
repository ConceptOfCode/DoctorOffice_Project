using DoctorOffice.DataLayer;
using Microsoft.EntityFrameworkCore;
using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DoctorOffice.Services
{
    public class patientsRepository : IPatientsRepository
    {
        ProjectContext db;
        public patientsRepository(ProjectContext DB)
        {
            this.db = DB;
        }

        public async Task<IEnumerable<patients>> getAllPatients()
        {
            return await Task.Run(() => db.Patients);
        }

        public async Task<patients> getPatientsById(int id)
        {
            return await db.Patients.FindAsync(id);
        }

        public async Task<bool> insertPatients(patients patients)
        {
            try
            {
                await db.Patients.AddAsync(patients);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editPatients(patients patients)
        {
            try
            {
                await Task.Run(() => db.Entry(patients).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletePatients(patients patients)
        {
            try
            {
                await Task.Run(() => db.Entry(patients).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletePatients(int id)
        {
            try
            {
                patients find = await getPatientsById(id);
                await deletePatients(find);
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

        public async Task<bool> isExistsPatients(int nationalID)
        {
            return await db.Patients.AnyAsync(a => a.nationalNumber == nationalID);
        }

        public async Task<bool> checkNationalNumberForEdit(int patientsID, int nationalID)
        {
            var find = await isExistsPatients(nationalID);
            if (find == false)
            {
                return true;
            }
            else
            {
                return await db.Patients.AnyAsync(a => a.patientsID == patientsID && a.nationalNumber == nationalID);
            }
        }

        public async Task<IEnumerable<patients>> getPatientsByNationalID(int nationalID)
        {
            return await Task.Run(() => db.Patients.Where(w => w.nationalNumber == nationalID));
        }

        public async Task<patients> getCurrentUserInformations(string Email)
        {
            return await db.Patients.Where(w => w.Email == Email).SingleOrDefaultAsync();
        }

        public async Task<bool> checkEmail(int patientsID, string Email)
        {
            var find = await isExistsPatientsByEmail(Email);
            if (find == false)
            {
                return true;
            }
            else
            {
                return await db.Patients.AnyAsync(a => a.patientsID == patientsID && a.Email == Email);
            }
        }

        public async Task<bool> isExistsPatientsByEmail(string Email)
        {
            return await db.Patients.AnyAsync(a => a.Email == Email);
        }

        public async Task<int> getPatientsCount()
        {
            return await db.Patients.CountAsync();
        }
    }
}
