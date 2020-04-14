using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Services;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class clinicSpecificationsController : Controller
    {
        IClinicOpeningHoursRepository ClinicOpeningHoursRepository;
        IClinicSpecificationsRepository ClinicSpecificationsRepository;

        public clinicSpecificationsController(IClinicSpecificationsRepository clinicSpecifications, IClinicOpeningHoursRepository clinicOpeningHours)
        {
            this.ClinicSpecificationsRepository = clinicSpecifications;
            this.ClinicOpeningHoursRepository = clinicOpeningHours;
        }

        [Route("clinic/informations")]
        public async Task<IActionResult> Index()
        {
            return View(await ClinicSpecificationsRepository.clinicInformationsLists());
        }

        [Route("clinic/newAddress")]
        public IActionResult insertData()
        {
            return View();
        }

        [HttpPost("insertClinicSpecifications")]
        public async Task<IActionResult> insertData(clinicSpecifications clinicSpecificationsParam, clinicOpeningHours clinicOpeningHoursParam)
        {
            if (clinicSpecificationsParam.isActive == true)
            {
                await ClinicSpecificationsRepository.disableAllClinicAddress();
            }

            //fillDateTime
            var specifactions = clinicSpecificationsParam;
            specifactions.createDate = DateTime.Now.toShamsi();

            //InsertSpecifications
            var result = await ClinicSpecificationsRepository.insertClinicSpecifications(specifactions);
            if (result)
            {
                await ClinicSpecificationsRepository.saveChanges();
            }

            //GetLastIDInserted
            var lastID = clinicSpecificationsParam.clinicSpecificationsID;

            //fillLastIDAndCreateDateTime
            var openingHours = clinicOpeningHoursParam;
            openingHours.createDate = DateTime.Now.toShamsi();
            openingHours.clinicSpecificationsID = lastID;

            //InsertOpeningHours
            var result2 = await ClinicOpeningHoursRepository.insertClinicOpeningHours(openingHours);
            if (result2)
            {
                await ClinicOpeningHoursRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }

        [Route("clinic/editAddress/{id}")]
        public async Task<IActionResult> updateData(int id)
        {
            var clinicSpecifications = await ClinicSpecificationsRepository.getclinicSpecificationsById(id);
            var clinicOpeningHours = await ClinicOpeningHoursRepository.getclinicOpeningHoursByClinicSpecificationId(id);

            var Data = Tuple.Create(clinicSpecifications, clinicOpeningHours);
            return await Task.Run(() => View(Data));
        }

        [HttpPost("updateClinicSpecifications")]
        public async Task<IActionResult> updateData(clinicSpecifications clinicSpecificationsParam, clinicOpeningHours clinicOpeningHoursParam)
        {
            var findClinicSpecifications = await ClinicSpecificationsRepository.getclinicSpecificationsById(clinicSpecificationsParam.clinicSpecificationsID);
            var findClinicOpeningHours = await ClinicOpeningHoursRepository.getclinicOpeningHoursById(clinicOpeningHoursParam.clinicOpeningHoursID);

            if (clinicSpecificationsParam.isActive == true)
            {
                await ClinicSpecificationsRepository.disableAllClinicAddress();
                await ClinicSpecificationsRepository.saveChanges();
            }

            findClinicSpecifications.countryName = clinicSpecificationsParam.countryName;
            findClinicSpecifications.cityName = clinicSpecificationsParam.cityName;
            findClinicSpecifications.streetName = clinicSpecificationsParam.streetName;
            findClinicSpecifications.clinicPhone = clinicSpecificationsParam.clinicPhone;
            findClinicSpecifications.clinicPlack = clinicSpecificationsParam.clinicPlack;
            findClinicSpecifications.isActive = clinicSpecificationsParam.isActive;
            findClinicSpecifications.fullAddress = clinicSpecificationsParam.fullAddress;
            findClinicSpecifications.createDate = DateTime.Now.toShamsi();

            findClinicOpeningHours.clinicSpecificationsID = clinicOpeningHoursParam.clinicSpecificationsID;
            findClinicOpeningHours.startTime = clinicOpeningHoursParam.startTime;
            findClinicOpeningHours.endTime = clinicOpeningHoursParam.endTime;
            findClinicOpeningHours.weekDay = clinicOpeningHoursParam.weekDay;
            findClinicOpeningHours.isActive = clinicSpecificationsParam.isActive; //if parent is false child is false
            findClinicOpeningHours.createDate = DateTime.Now.toShamsi();

            bool result = await ClinicSpecificationsRepository.editclinicSpecifications(findClinicSpecifications);
            bool result2 = await ClinicOpeningHoursRepository.editClinicOpeningHours(findClinicOpeningHours);

            if (result == true)
            {
                await ClinicSpecificationsRepository.saveChanges();
            }

            if (result2 == true)
            {
                await ClinicOpeningHoursRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }

        ~clinicSpecificationsController()
        {
            ClinicOpeningHoursRepository.Dispose();
            ClinicSpecificationsRepository.Dispose();
        }
    }
}