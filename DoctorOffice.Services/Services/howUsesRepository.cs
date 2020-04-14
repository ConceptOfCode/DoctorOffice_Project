using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Services
{
    public class howUsesRepository : IHowUsesRepository
    {
        ProjectContext db;
        public howUsesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<howUse>> getAllhowUse()
        {
            return await Task.Run(() => db.howUses);
        }

        public async Task<howUse> gethowUseById(int id)
        {
            return await db.howUses.FindAsync(id);
        }

        public async Task<bool> inserthowUse(howUse howUse)
        {
            try
            {
                await db.howUses.AddAsync(howUse);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> edithowUse(howUse howUse)
        {
            try
            {
                await Task.Run(() => db.Entry(howUse).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletehowUse(howUse howUse)
        {
            try
            {
                await Task.Run(() => db.Entry(howUse).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deletehowUse(int id)
        {
            try
            {
                howUse find = await gethowUseById(id);
                await deletehowUse(find);
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
