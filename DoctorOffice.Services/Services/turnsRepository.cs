using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;
using DoctorOffice.ViewModels;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice.Services
{
    public class turnsRepository : ITurnsRepository
    {
        ProjectContext db;
        public turnsRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Turns>> getAllTurns()
        {
            return await Task.Run(() => db.Turns);
        }

        public async Task<Turns> getTurnsById(int id)
        {
            return await db.Turns.FindAsync(id);
        }

        public async Task<bool> insertTurns(Turns turns)
        {
            try
            {
                await db.Turns.AddAsync(turns);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editTurns(Turns turns)
        {
            try
            {
                await Task.Run(() => db.Entry(turns).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteTurns(Turns turns)
        {
            try
            {
                await Task.Run(() => db.Entry(turns).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteTurns(int id)
        {
            try
            {
                Turns find = await getTurnsById(id);
                await deleteTurns(find);
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

        public async Task<IEnumerable<SecretaryReserveList_ViewModel>> getReserveList()
        {
            return await Task.Run(() => db.Turns.Select(s => new SecretaryReserveList_ViewModel()
            {
                turnsID = s.turnsID,
                reserveDate = s.reserveDate,
                currentDate = DateTime.Now.toShamsi(),
                doctorFullName = s.Employees.firstName + " " + s.Employees.lastName
            }));
        }

        public async Task<IEnumerable<PatientReserveList_ViewModel>> getPatientReserveList(string Email)
        {
            return await Task.Run(() => db.Turns.Select(s => new PatientReserveList_ViewModel()
            {
                turnsID = s.turnsID,
                currentDate = DateTime.Now.toShamsi(),
                reserveDate = s.reserveDate,
                doctorFullName = s.Employees.firstName + " " + s.Employees.lastName,
                PatientEmail = s.Patients.Email
            }).Where(w=> w.PatientEmail == Email));
        }

        public async Task<SecretaryreserveDetails_ViewModel> getDetails(int turnsID)
        {
            return await db.Turns.Select(s => new SecretaryreserveDetails_ViewModel()
            {
                turnsID = s.turnsID,
                fullNamePatient = s.Patients.firstName + " " + s.Patients.lastName,
                birthDate = s.Patients.birthDate,
                Email = s.Patients.Email,
                fatherName = s.Patients.fatherName,
                nationalNumber = s.Patients.nationalNumber,
                phoneNumber = s.Patients.phoneNumber,
                reserveDate = s.reserveDate,
                currentDate = DateTime.Now.toShamsi()
            }).Where(w => w.turnsID == turnsID).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<SecretaryReserveList_ViewModel>> searchList(string reserveDate)
        {
            return await Task.Run(() => db.Turns.Select(s => new SecretaryReserveList_ViewModel()
            {
                turnsID = s.turnsID,
                reserveDate = s.reserveDate,
                currentDate = DateTime.Now.toShamsi(),
                doctorFullName = s.Employees.firstName + " " + s.Employees.lastName
            }).Where(w => w.reserveDate.Contains(reserveDate)));
        }
    }
}
