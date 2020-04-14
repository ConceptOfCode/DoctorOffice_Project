using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Services;
using DoctorOffice.ViewModels;

namespace DoctorOffice_Project.Views.Home.Components.HeaderSiteComponent
{
    public class HeaderSiteComponent : ViewComponent
    {
        IClinicOpeningHoursRepository clinicOpeningHoursRepository;

        public HeaderSiteComponent(IClinicOpeningHoursRepository clinicOpeningHours)
        {
            this.clinicOpeningHoursRepository = clinicOpeningHours;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await clinicOpeningHoursRepository.headerInformationsSite();
            dynamic shortAddress = data.shortAddress;
            shortAddress = shortAddress.Split('-');
            shortAddress = shortAddress[1] + "-" + shortAddress[2];
            data.shortAddress = shortAddress;

            return await Task.FromResult((IViewComponentResult)View("headerSite", data));
        }
    }
}
