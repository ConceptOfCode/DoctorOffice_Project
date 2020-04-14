using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Services;
using DoctorOffice.Domains;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class ServicesController : Controller
    {
        IServicesRepository servicesRepository;
        public ServicesController(IServicesRepository services)
        {
            this.servicesRepository = services;
        }
        [Route("clinic/services")]
        public async Task<IActionResult> Index()
        {
            var allServices = await servicesRepository.getAllServices();
            return await Task.Run(() => View(allServices));
        }

        [Route("clinic/newService")]
        public async Task<IActionResult> insertData()
        {
            return await Task.Run(() => View());
        }

        [HttpGet("getCountServices")]
        public async Task<int> getCountEnableServices()
        {
            return await servicesRepository.getEnableServicesCount();
        }

        [HttpGet("IsExistsInSet/{serviceID}")]
        public async Task<bool> isExistsInSet(int serviceID)
        {
            return await servicesRepository.isExistsInSet(serviceID);
        }

        [HttpPost("SservicesInsertData")]
        public async Task<IActionResult> insertData(Services services)
        {
            bool deleteResult = false;
            bool insertResult = false;

            if (services.showInPage == true)
            {
                var servicesEnable = await servicesRepository.getEnableService();

                if (servicesEnable.Count() >= 6)
                {
                    var removeItem = servicesEnable.First();
                    deleteResult = await servicesRepository.deleteServices(removeItem.ServicesID);
                }

                if (deleteResult == true)
                {
                    await servicesRepository.saveChanges();
                }
            }

            services.createDateTime = DateTime.Now.toShamsi();
            insertResult = await servicesRepository.insertServices(services);

            if (insertResult == true)
            {
                await servicesRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }

        [Route("clinic/editService/{id}")]
        public async Task<IActionResult> updateData(int id)
        {
            var Service = await servicesRepository.getServicesById(id);
            return View(Service);
        }

        [HttpPost("SservicesUpdatetData")]
        public async Task<IActionResult> updateData(Services services)
        {
            services.createDateTime = DateTime.Now.toShamsi();
            var result = await servicesRepository.editServices(services);

            if (result == true)
            {
                await servicesRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}