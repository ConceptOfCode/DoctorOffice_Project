using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class medicinesRepository : IMedicinesRpository
    {
        ProjectContext db;
        public medicinesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Medicine>> getAllMedicine()
        {
            return await Task.Run(() => db.Medicines);
        }

        public async Task<Medicine> getMedicineById(int id)
        {
            return await db.Medicines.FindAsync(id);
        }

        public async Task<bool> insertMedicine(Medicine medicine)
        {
            try
            {
                await db.Medicines.AddAsync(medicine);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editMedicine(Medicine medicine)
        {
            try
            {
                await Task.Run(() => db.Entry(medicine).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteMedicine(Medicine medicine)
        {
            try
            {
                await Task.Run(() => db.Entry(medicine).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteMedicine(int id)
        {
            try
            {
                Medicine find = await getMedicineById(id);
                await deleteMedicine(find);
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
