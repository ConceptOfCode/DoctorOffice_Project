using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Authorize(Roles = "doctor")]
    [Area("doctorPanel")]
    public class HomeController : Controller
    {
        [Route("doctorPanel")]
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }
    }
}