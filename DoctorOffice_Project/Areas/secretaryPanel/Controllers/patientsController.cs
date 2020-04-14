using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Domains;
using DoctorOffice.DataLayer;
using DoctorOffice.Services;
using DoctorOffice.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class patientsController : Controller
    {
        IPatientsRepository patientsRepository;
        public patientsController(IPatientsRepository patients)
        {
            this.patientsRepository = patients;
        }

        [Route("Clinic/PatientsList")]
        public async Task<IActionResult> Index()
        {
            var listPatients = await patientsRepository.getAllPatients();
            return await Task.Run(() => View(listPatients));
        }

        [HttpGet("searchPatients/{nationalID}")]
        public async Task<IEnumerable<patients>> searchPatients(int nationalID)
        {
            return await patientsRepository.getPatientsByNationalID(nationalID);
        }

        [HttpGet("isExitsPatients/{nationalID}")]
        public async Task<bool> isExists(int nationalID)
        {
            return await patientsRepository.isExistsPatients(nationalID);
        }

        [Route("Clinic/addPatients")]
        public async Task<IActionResult> insertData()
        {
            return await Task.Run(() => View());
        }

        [HttpPost("insertPatients")]
        public async Task<IActionResult> insertData(patients patients, IFormFile imgUp)
        {
            //if (imgUp != null)
            //{
            //    patients.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
            //    string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploadImages", patients.imageName);

            //    using (var stream = new FileStream(savePath, FileMode.Create))
            //    {
            //        await stream.CopyToAsync(stream);
            //    }
            //}

            if (imgUp != null)
            {
                patients.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                string savePath = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/uploadImages", patients.imageName
                );

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imgUp.CopyToAsync(stream);
                }

            }
            patients.createDate = DateTime.Now.toShamsi();
            var result = await patientsRepository.insertPatients(patients);

            if (result == true)
            {
                await patientsRepository.saveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("checkForEdit/{patientsID}/{nationalID}")]
        public async Task<bool> checkNationalIdForEdit(int patientsID, int nationalID)
        {
            return await patientsRepository.checkNationalNumberForEdit(patientsID, nationalID);
        }

        [Route("Clinic/editPatients/{id}")]
        public async Task<IActionResult> updateData(int id)
        {
            var data = await patientsRepository.getPatientsById(id);
            return View(data);
        }

        [HttpPost("UpdatePatients")]
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

        [HttpPost("DeletePatients/{id}")]
        public async Task<IActionResult> deleteData(int id)
        {
            var result = await patientsRepository.deletePatients(id);

            if(result == true)
            {
                await patientsRepository.saveChanges();
            }

            return Json("/Clinic/PatientsList");
        }
    }
}