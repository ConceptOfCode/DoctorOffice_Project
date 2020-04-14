using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Services;
using DoctorOffice.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Area("doctorPanel")]
    public class TurnsController : Controller
    {
        ITurnsRepository turnsRepository;
        public TurnsController(ITurnsRepository turns)
        {
            this.turnsRepository = turns;
        }

        [Route("doctorPanel/reserveList")]
        public async Task<IActionResult> Index()
        {
            var allReserveList = await turnsRepository.getReserveList();
            return View(allReserveList);
        }

        [Route("doctorPanel/reserveDetails/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var getDetail = await turnsRepository.getDetails(id);
            return View(getDetail);
        }

    }
}