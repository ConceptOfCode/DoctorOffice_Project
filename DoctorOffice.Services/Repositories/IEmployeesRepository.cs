using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;

namespace DoctorOffice.Services
{
    public interface IEmployeesRepository : IDisposable
    {
        Task<IEnumerable<Employees>> getAllEmployees();

        Task<Employees> getEmployeesById(int id);

        Task<Employees> getEmployeeByEmail(string Email);

        Task<bool> isExistsEmployeeByNationalID(int nationalID);

        Task<bool> isExistsEmployeeByEmail(string Email);

        Task<bool> insertEmployee(Employees employees);

        Task<bool> editEmployee(Employees employees);

        Task<bool> deleteEmployee(Employees employees);

        Task<bool> deleteEmployee(int id);

        Task saveChanges();

        Task<bool> checkEmail(int empID, string Email);

        Task<bool> checkNationalID(int empID, int nationalID);

        Task<Employees> getCurrentUserInformations(string Email);
    }
}
