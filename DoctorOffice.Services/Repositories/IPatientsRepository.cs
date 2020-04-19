using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;

namespace DoctorOffice.Services
{
    public interface IPatientsRepository : IDisposable
    {
       Task<IEnumerable<patients>> getAllPatients();

        Task<patients> getPatientsById(int id);

        Task<bool> insertPatients(patients patients);

        Task<bool> editPatients(patients patients);

        Task<bool> deletePatients(patients patients);

        Task<bool> deletePatients(int id);

        Task saveChanges();

        Task<bool> isExistsPatients(int nationalID);

        Task<bool> isExistsPatientsByEmail(string Email);

        Task<bool> checkNationalNumberForEdit(int patientsID,int nationalID);

        Task<bool> checkEmail(int empID, string Email);

        Task<IEnumerable<patients>> getPatientsByNationalID(int nationalID);

        Task<patients> getCurrentUserInformations(string Email);

        Task<int> getPatientsCount();
    }
}
