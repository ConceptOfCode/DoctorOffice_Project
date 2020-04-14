using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public class clinicSpecificationsRepository : IClinicSpecificationsRepository
    {
        ProjectContext db;

        public clinicSpecificationsRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<clinicSpecifications>> getAllClinicSpecifications()
        {
            return await Task.Run(() => db.clinicSpecifications);
        }

        public async Task<clinicSpecifications> getclinicSpecificationsById(int id)
        {
            return await db.clinicSpecifications.FindAsync(id);
        }

        public async Task<bool> insertClinicSpecifications(clinicSpecifications clinicSpecifications)
        {
            try
            {
                await db.clinicSpecifications.AddAsync(clinicSpecifications);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editclinicSpecifications(clinicSpecifications clinicSpecifications)
        {
            try
            {
                await Task.Run(() => db.Entry(clinicSpecifications).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteclinicSpecifications(clinicSpecifications clinicSpecifications)
        {
            try
            {
                await Task.Run(() => db.Entry(clinicSpecifications).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteclinicSpecifications(int id)
        {
            try
            {
                clinicSpecifications find = await getclinicSpecificationsById(id);
                await deleteclinicSpecifications(find);
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

        public async Task<IEnumerable<clinicInformationsList>> clinicInformationsLists()
        {
            return await Task.Run(() => db.clinicOpeningHours.Select(s => new clinicInformationsList()
            {
                clinicSpecificationsID = s.clinicSpecificationsID,
                shortAddress = s.clinicSpecifications.cityName + "-" + s.clinicSpecifications.streetName,
                startTime = s.startTime,
                endTime = s.endTime,
                isActive = s.clinicSpecifications.isActive
            }));
        }

        public async Task disableAllClinicAddress()
        {
            var allAddress = await getAllClinicSpecifications();
         
            foreach(var item in allAddress)
            {
                item.isActive = false;
                await editclinicSpecifications(item);
            }
        }
    }
}
