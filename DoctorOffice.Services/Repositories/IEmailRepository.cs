using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface IEmailRepository : IDisposable
    {
        Task<IEnumerable<Email>> getAllEmail();

        Task<Email> getEmailById(int id);

        Task<bool> insertEmail(Email email);

        Task<bool> editEmail(Email email);

        Task<bool> deleteEmail(Email email);

        Task<bool> deleteEmail(int id);

        void saveChanges();
    }
}
