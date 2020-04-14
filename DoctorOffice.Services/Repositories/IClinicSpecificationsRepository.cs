using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface IClinicSpecificationsRepository : IDisposable
    {
        Task<IEnumerable<clinicSpecifications>> getAllClinicSpecifications();

        Task<clinicSpecifications> getclinicSpecificationsById(int id);

        Task<bool> insertClinicSpecifications(clinicSpecifications clinicSpecifications);

        Task<bool> editclinicSpecifications(clinicSpecifications clinicSpecifications);

        Task<bool> deleteclinicSpecifications(clinicSpecifications clinicSpecifications);

        Task<bool> deleteclinicSpecifications(int id);

        Task<IEnumerable<clinicInformationsList>> clinicInformationsLists();

        Task disableAllClinicAddress();

        Task saveChanges();
    }
}
