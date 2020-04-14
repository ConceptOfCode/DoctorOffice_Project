using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Services;
using DoctorOffice.DataLayer;
using DoctorOffice.ViewModels;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class TurnsController : Controller
    {
        ITurnsRepository turnsRepository;
        public TurnsController(ITurnsRepository turns)
        {
            this.turnsRepository = turns;
        }

        [Route("Clinic/reserveList")]
        public async Task<IActionResult> Index()
        {
            var allReserveList = await turnsRepository.getReserveList();
            return View(allReserveList);
        }

        [Route("Clinic/reserveDetails/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var getDetail = await turnsRepository.getDetails(id);
            return View(getDetail);
        }

        [HttpGet("searchListTurns/{reserveDate}")]
        public async Task<IEnumerable<SecretaryReserveList_ViewModel>> searchList(string reserveDate)
        {
           var s= await turnsRepository.searchList(reserveDate);
            return s;
        }
    }
}