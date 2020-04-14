using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.Services;

namespace DoctorOffice_Project.Views.Home.Components.ServicesComponent
{
    public class ServicesComponent : ViewComponent
    {
        IServicesRepository servicesRepository;
        public ServicesComponent(IServicesRepository services)
        {
            this.servicesRepository = services;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await servicesRepository.getEnableServicesForSite();
            return await Task.FromResult((IViewComponentResult)View("services", data));
        }
    }
}
