using DoctorOffice.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public class servicesRepository : IServicesRepository
    {
        ProjectContext db;
        public servicesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Domains.Services>> getAllServices()
        {
            return await Task.Run(() => db.Services);
        }

        public async Task<Domains.Services> getServicesById(int id)
        {
            return await db.Services.FindAsync(id);
        }

        public async Task<bool> insertServices(Domains.Services Services)
        {
            try
            {
                await db.Services.AddAsync(Services);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editServices(Domains.Services Services)
        {
            try
            {
                await Task.Run(() => db.Entry(Services).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteServices(Domains.Services Services)
        {
            try
            {
                await Task.Run(() => db.Entry(Services).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteServices(int id)
        {
            try
            {
                var find = await getServicesById(id);
                await deleteServices(find);
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

        public async Task<IEnumerable<DoctorOffice.Domains.Services>> getEnableService()
        {
            return await Task.Run(() => db.Services.Where(w => w.showInPage == true).OrderBy(o => o.createDateTime));
        }

        public async Task<int> getEnableServicesCount()
        {
            return await db.Services.Where(w => w.showInPage == true).CountAsync();
        }

        public async Task<bool> isExistsInSet(int serviceID)
        {
            return await db.Services.Where(w => w.showInPage == true).AnyAsync(a => a.ServicesID == serviceID);
        }

        public async Task<IEnumerable<DoctorOffice.Domains.Services>> getEnableServicesForSite()
        {
            return await Task.Run(() => db.Services.Where(w => w.showInPage == true).OrderBy(o => o.Order));
        }
    }
}
