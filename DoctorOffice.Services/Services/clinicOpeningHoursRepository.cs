using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice.Services
{
    public class clinicOpeningHoursRepository : IClinicOpeningHoursRepository
    {
        ProjectContext db;
        public clinicOpeningHoursRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<clinicOpeningHours>> getAllclinicOpeningHours()
        {
            return await Task.Run(() => db.clinicOpeningHours);
        }

        public async Task<clinicOpeningHours> getclinicOpeningHoursById(int id)
        {
            return await db.clinicOpeningHours.FindAsync(id);
        }

        public async Task<bool> insertClinicOpeningHours(clinicOpeningHours ClinicOpeningHours)
        {
            try
            {
                await db.clinicOpeningHours.AddAsync(ClinicOpeningHours);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editClinicOpeningHours(clinicOpeningHours ClinicOpeningHours)
        {
            try
            {
                await Task.Run(() => db.Entry(ClinicOpeningHours).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteClinicOpeningHours(clinicOpeningHours ClinicOpeningHours)
        {
            try
            {
                await Task.Run(() => db.Entry(ClinicOpeningHours).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteClinicOpeningHours(int id)
        {
            try
            {
                clinicOpeningHours find = await getclinicOpeningHoursById(id);
                await deleteClinicOpeningHours(find);
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

        public async Task<clinicOpeningHours> getclinicOpeningHoursByClinicSpecificationId(int id)
        {
            return await db.clinicOpeningHours.Where(w => w.clinicSpecificationsID == id).SingleOrDefaultAsync();
        }

        public async Task<HeaderInformationSite_ViewModel> headerInformationsSite()
        {
            return await db.clinicOpeningHours.Select(s => new HeaderInformationSite_ViewModel()
            {
                fullAddress = s.clinicSpecifications.fullAddress,
                shortAddress = s.clinicSpecifications.fullAddress,
                clinicPhone = s.clinicSpecifications.clinicPhone,
                currentDateTime = DateTime.Now.toShamsi(),
                isActive = s.clinicSpecifications.isActive
            }).Where(w => w.isActive == true).SingleOrDefaultAsync();
        }

        public async Task<FooterOpeningHours_ViewModel> footerOpeningHoursSite()
        {
            return await db.clinicOpeningHours.Select(s => new FooterOpeningHours_ViewModel()
            {
                weekDays = s.weekDay,
                startTime = s.startTime,
                endTime = s.endTime,
                isActive = s.clinicSpecifications.isActive
            }).Where(w => w.isActive == true).SingleOrDefaultAsync();
        }
    }
}
