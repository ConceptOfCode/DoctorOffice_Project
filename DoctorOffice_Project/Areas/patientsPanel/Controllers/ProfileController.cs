using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using Microsoft.AspNetCore.Http;
using DoctorOffice.ExtensionMethods;
using System.IO;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    [Area("patientsPanel")]
    public class ProfileController : Controller
    {
        [Route("Patients/Profile")]
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        [HttpPost("insertProfile")]
        public async Task<IActionResult> insertData(patients patients, IFormFile imgUp)
        {
            patients.createDate = DateTime.Now.toShamsi();
            if(imgUp != null)
            {
                patients.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploadImages", patients.imageName);

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imgUp.CopyToAsync(stream);
                }
            }

            return null;
        }
    }
}