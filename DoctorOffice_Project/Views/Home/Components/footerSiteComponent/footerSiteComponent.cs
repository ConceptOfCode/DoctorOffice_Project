using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Services;
using DoctorOffice.ViewModels;

namespace DoctorOffice_Project.Views.Home.Components.footerSiteComponent
{
    public class footerSiteComponent : ViewComponent
    {
        IClinicOpeningHoursRepository clinicOpeningHoursRepository;
        IServicesRepository servicesRepository;
        public footerSiteComponent(IClinicOpeningHoursRepository clinicOpeningHours, IServicesRepository services)
        {
            this.clinicOpeningHoursRepository = clinicOpeningHours;
            this.servicesRepository = services;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await clinicOpeningHoursRepository.footerOpeningHoursSite();
            string[] weekDays = data.weekDays.Split('|').Where(w=> w != " ").ToArray();
            var services = await servicesRepository.getEnableServicesForSite();

            var dataSender = Tuple.Create(weekDays, data.startTime, data.endTime, services);

            return await Task.FromResult((IViewComponentResult)View("footerSite", dataSender));
        }
    }
}
