using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;

namespace DoctorOffice.Services
{
    public interface ITemporaryPatientsRepository : IDisposable
    {
        Task<IEnumerable<Temporarypatients>> getAllTemporaryPatients();

        Task<Temporarypatients> getTemporaryPatientsById(int id);

        Task<bool> insertTemporaryPatients(Temporarypatients temporaryPatients);

        Task<bool> editTemporaryPatients(Temporarypatients temporaryPatients);

        Task<bool> deleteTemporaryPatients(Temporarypatients temporaryPatients);

        Task<bool> deleteTemporaryPatients(int id);

        void saveChanges();
    }
}
