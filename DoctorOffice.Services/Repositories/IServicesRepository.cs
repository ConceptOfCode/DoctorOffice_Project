using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface IServicesRepository : IDisposable
    {
        Task<IEnumerable<DoctorOffice.Domains.Services>> getAllServices();

        Task<DoctorOffice.Domains.Services> getServicesById(int id);

        Task<bool> insertServices(DoctorOffice.Domains.Services Services);

        Task<bool> editServices(DoctorOffice.Domains.Services Services);

        Task<bool> deleteServices(DoctorOffice.Domains.Services Services);

        Task<bool> deleteServices(int id);

        Task saveChanges();

        Task<IEnumerable<DoctorOffice.Domains.Services>> getEnableService();

        Task<IEnumerable<DoctorOffice.Domains.Services>> getEnableServicesForSite();

        Task<int> getEnableServicesCount();

        Task<bool> isExistsInSet(int serviceID);
    }
}
