using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface IHowUsesRepository : IDisposable
    {
        Task<IEnumerable<howUse>> getAllhowUse();

        Task<howUse> gethowUseById(int id);

        Task<bool> inserthowUse(howUse howUse);

        Task<bool> edithowUse(howUse howUse);

        Task<bool> deletehowUse(howUse howUse);

        Task<bool> deletehowUse(int id);

        Task saveChanges();
    }
}
