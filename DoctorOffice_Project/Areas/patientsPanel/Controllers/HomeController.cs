using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    
    [Area("patientsPanel")]
    public class HomeController : Controller
    {
        [Route("patientsPanel")]
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        //[Route("Parients/Profile")]
        //public async Task<IActionResult> Profile()
        //{
        //    return await Task.Run(() => View());
        //}

        //public async Task<IActionResult> Reserve()
        //{
        //    return await Task.Run(() => View());
        //}

        //public async Task<IActionResult> reserveList()
        //{
        //    return await Task.Run(() => View());
        //}

        //public async Task<IActionResult> Notes()
        //{
        //    return await Task.Run(() => View());
        //}

    }
}