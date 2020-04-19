using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.DataLayer;
using DoctorOffice.Services;
using DoctorOffice.ViewModels;
using DoctorOffice.Domains;
using DoctorOffice.ExtensionMethods;
using Newtonsoft.Json;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    [Area("patientsPanel")]
    public class ReserveController : Controller
    {
        ITurnsRepository turnsRepository;
        IPatientsRepository patientsRepository;
        IEmployeesRepository employeesRepository;

        public ReserveController(ITurnsRepository turns, IPatientsRepository patients, IEmployeesRepository employees)
        {
            this.turnsRepository = turns;
            this.patientsRepository = patients;
            this.employeesRepository = employees;
        }

        [Route("PatientsPanel/Reserve")]
        public async Task<IActionResult> Reserve()
        {
            var currentUserInfo = Tuple.Create(await patientsRepository.getCurrentUserInformations(User.Identity.Name), await employeesRepository.getAllEmployees());
            return View(currentUserInfo);
        }

        [HttpPost("PatientsPanel/newReserve")]
        public async Task<IActionResult> Reserve(PatientsReserve_ViewModel Reserve)
        {
            var reserveItem = new Turns()
            {
                patientsID = Reserve.PatientID,
                employeeID = Reserve.employeeID,
                reserveDate = Reserve.reserveDate,
                createDate = DateTime.Now.toShamsi(),
                statusTurn = (int)DoctorOffice.Enums.constantConcepts.Status.success,
                Descriptions = Reserve.Description
            };

            var result = await turnsRepository.insertTurns(reserveItem);
            if (result == true)
            {
                await turnsRepository.saveChanges();
            }
            return RedirectToAction("reserveList");
        }

        [Route("PatientsPanel/reserveList")]
        public async Task<IActionResult> reserveList()
        {
            var data = await turnsRepository.getPatientReserveList(User.Identity.Name);
            return View(data);
        }

        [Route("PatientsPanel/ReserveDetails/{TurnsID}")]
        public async Task<IActionResult> Details(int TurnsID)
        {
            var data = await turnsRepository.getDetails(TurnsID);
            return View(data);
        }

        [Route("PatientsPanel/searchReserve/{Date}")]
        public async Task<jsonResult> searchReserve(string Date)
        {
            var data = await turnsRepository.searchList(Date.Replace('$','/'));
            if (data.Any())
            {
                return jsonResult.GetJsonResult((int)DoctorOffice.Enums.constantConcepts.httpStatus.successed, DoctorOffice.Enums.constantConcepts.httpStatus.successed.ToString(), "/PatientsPanel/reserveList", JsonConvert.SerializeObject(data));
            }

            return jsonResult.GetJsonResult((int)DoctorOffice.Enums.constantConcepts.httpStatus.notFound, DoctorOffice.Enums.constantConcepts.httpStatus.notFound.ToString(), "", "");
        }
    }
}