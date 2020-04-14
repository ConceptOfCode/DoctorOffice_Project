using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface ISmsRepository :IDisposable
    {
        Task<IEnumerable<SMS>> getAllSMS();

        Task<SMS> getSMSById(int id);

        Task<bool> insertSMS(SMS SMS);

        Task<bool> editSMS(SMS SMS);

        Task<bool> deleteSMS(SMS SMS);

        Task<bool> deleteSMS(int id);

        void saveChanges();
    }
}
