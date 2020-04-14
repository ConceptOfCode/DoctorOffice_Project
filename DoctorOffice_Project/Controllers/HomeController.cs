using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoctorOffice.DataLayer;
using DoctorOffice.Services;
using DoctorOffice.Domains;
using DoctorOffice.Enums;

namespace DoctorOffice_Project.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        [Route("NewPatients")]
        public async Task<IActionResult> createPatients()
        {
            return await Task.Run(()=> View());
        }

        [Route("Login")]
        public async Task<IActionResult> Login()
        {
            return await Task.Run(() => View());
        }
    }
}
