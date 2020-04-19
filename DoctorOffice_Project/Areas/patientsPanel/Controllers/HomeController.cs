using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Services;
using DoctorOffice.Domains;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    [Authorize(Roles = "patients")]
    [Area("patientsPanel")]
    public class HomeController : Controller
    {
        IMemoriesRepository memoriesRepository;
        IPatientsRepository patientsRepository;

        public HomeController(IMemoriesRepository memories, IPatientsRepository patients)
        {
            this.memoriesRepository = memories;
            this.patientsRepository = patients;
        }
        [Route("patientsPanel")]
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        [Route("patientsPanel/newMemories")]
        public async Task<IActionResult> insertMemories()
        {
            var currentUser = await patientsRepository.getCurrentUserInformations(User.Identity.Name);
            return View(currentUser);
        }

        [HttpPost("patientsPanel/newMemories")]
        public async Task<IActionResult> insertMemories(Memories memories)
        {
            memories.createDate = DateTime.Now.toShamsi();
            var result = await memoriesRepository.insertMemories(memories);
            if (result == true)
            {
                await memoriesRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}