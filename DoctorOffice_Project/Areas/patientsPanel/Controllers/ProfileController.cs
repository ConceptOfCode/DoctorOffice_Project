using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.Services;
using Microsoft.AspNetCore.Http;
using DoctorOffice.ExtensionMethods;
using System.IO;
using constantConcepts = DoctorOffice.Enums.constantConcepts;

namespace DoctorOffice_Project.Areas.patientsPanel.Controllers
{
    [Area("patientsPanel")]
    public class ProfileController : Controller
    {
        IPatientsRepository patientsRepository;

        public ProfileController(IPatientsRepository patients)
        {
            this.patientsRepository = patients;
        }

        [Route("Patients/Profile")]
        public async Task<IActionResult> Index()
        {
            var data = await patientsRepository.getCurrentUserInformations(User.Identity.Name);
            if (data != null)
            {
                ViewBag.Status = constantConcepts.Status.success;
            }
            else
            {
                ViewBag.Status = constantConcepts.Status.error;
            }
            return View(data);
        }

        //بیماران ثبت اطلاعات ندارند چون در تشکیل پرئنده همیشه این کار انجام میشود
        //  [HttpPost("insertProfile")]
        //public async Task<IActionResult> insertData(patients patients, IFormFile imgUp)
        //{
        //    patients.createDate = DateTime.Now.toShamsi();
        //    if(imgUp != null)
        //    {
        //        patients.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
        //        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploadImages", patients.imageName);

        //        using (var stream = new FileStream(savePath, FileMode.Create))
        //        {
        //            await imgUp.CopyToAsync(stream);
        //        }
        //    }

        //    return null;
        //} 

        [HttpGet("checkBeforeUpdatePatients/{patientID}/{nationalID}/{Email}")]
        public async Task<bool> updateData(int patientID, int nationalID, string Email)
        {
            var EmailResult = await patientsRepository.checkEmail(patientID, Email);
            var nationalIdResult = await patientsRepository.checkNationalNumberForEdit(patientID, nationalID);

            if (EmailResult == true && nationalIdResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost("PatientsPanel/UpdateProfile")]
        public async Task<IActionResult> updateData(patients patients, IFormFile imgUp)
        {
            if (imgUp != null)
            {
                if (patients.imageName == null)
                {
                    patients.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                }

                string savePath = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/uploadImages", patients.imageName
                );

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imgUp.CopyToAsync(stream);
                }

            }

            patients.createDate = DateTime.Now.toShamsi();

            var result = await patientsRepository.editPatients(patients);
            if (result == true)
            {
                await patientsRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}