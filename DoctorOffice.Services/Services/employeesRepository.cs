using DoctorOffice.Domains;
using DoctorOffice.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DoctorOffice.Services
{
    public class employeesRepository : IEmployeesRepository
    {
        ProjectContext db;
        public employeesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Employees>> getAllEmployees()
        {
            return await Task.Run(() => db.Employees);
        }

        public async Task<Employees> getEmployeesById(int id)
        {
            return await db.Employees.FindAsync(id);
        }

        public async Task<bool> insertEmployee(Employees employees)
        {
            try
            {
                await db.Employees.AddAsync(employees);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editEmployee(Employees employees)
        {
            try
            {
                await Task.Run(() => db.Entry(employees).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> deleteEmployee(Employees employees)
        {
            try
            {
                await Task.Run(() => db.Entry(employees).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteEmployee(int id)
        {
            try
            {
                Employees find = await getEmployeesById(id);
                await deleteEmployee(find);
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

        public async Task<Employees> getEmployeeByEmail(string Email)
        {
            return await db.Employees.Where(w => w.Email == Email).SingleOrDefaultAsync();
        }

        public async Task<bool> isExistsEmployeeByNationalID(int nationalID)
        {
            return await db.Employees.AnyAsync(a => a.nationalNumber == nationalID);
        }

        public async Task<bool> isExistsEmployeeByEmail(string Email)
        {
            return await db.Employees.AnyAsync(a => a.Email == Email);
        }

        public async Task<bool> checkEmail(int empID, string Email)
        {
            var find = await isExistsEmployeeByEmail(Email);
            if(find == false)
            {
                return true;
            }
            else
            {
                return await db.Employees.AnyAsync(a => a.employeeID == empID && a.Email == Email);
            }
        }

        public async Task<bool> checkNationalID(int empID, int nationalID)
        {
            var find = await isExistsEmployeeByNationalID(nationalID);
            if(find == false)
            {
                return true;
            }
            else
            {
                return await db.Employees.AnyAsync(a => a.employeeID == empID && a.nationalNumber == nationalID);
            }
        }

        public async Task<Employees> getCurrentUserInformations(string Email)
        {
            return await db.Employees.Where(w => w.Email == Email).SingleOrDefaultAsync();
        }

        public async Task<int> GetDoctorCount()
        {
            return await db.Employees.CountAsync(c => c.Type == 1);
        }
    }
}
