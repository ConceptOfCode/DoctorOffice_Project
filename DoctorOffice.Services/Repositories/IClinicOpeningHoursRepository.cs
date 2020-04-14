using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface IClinicOpeningHoursRepository : IDisposable
    {
        Task<IEnumerable<clinicOpeningHours>> getAllclinicOpeningHours();

        Task<clinicOpeningHours> getclinicOpeningHoursById(int id);

        Task<clinicOpeningHours> getclinicOpeningHoursByClinicSpecificationId(int id);

        Task<bool> insertClinicOpeningHours(clinicOpeningHours ClinicOpeningHours);

        Task<bool> editClinicOpeningHours(clinicOpeningHours ClinicOpeningHours);

        Task<bool> deleteClinicOpeningHours(clinicOpeningHours ClinicOpeningHours);

        Task<bool> deleteClinicOpeningHours(int id);

        Task saveChanges();

        Task<HeaderInformationSite_ViewModel> headerInformationsSite();

        Task<FooterOpeningHours_ViewModel> footerOpeningHoursSite();
    }
}
