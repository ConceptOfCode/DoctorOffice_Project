using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.DataLayer;
using DoctorOffice.Services;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
     [Area("patientsPanel")]
    public class ReserveController : Controller
    {
        ITurnsRepository turnsRepository;
        public ReserveController(ITurnsRepository turns)
        {
            this.turnsRepository = turns;
        }

        [Route("Patients/Reserve")]
        public async Task<IActionResult> Reserve()
        {
            return await Task.Run(()=> View());
        }

        [Route("Patients/reserveList")]
        public async Task<IActionResult> reserveList()
        {
            return await Task.Run(() => View());
        }
    }
}