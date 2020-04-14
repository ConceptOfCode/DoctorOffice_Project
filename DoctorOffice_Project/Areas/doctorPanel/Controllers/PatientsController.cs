using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.ExtensionMethods;
using DoctorOffice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Area("doctorPanel")]
    public class PatientsController : Controller
    {
        IPatientsRepository patientsRepository;
        public PatientsController(IPatientsRepository patients)
        {
            this.patientsRepository = patients;
        }

        [Route("DoctorPanel/PatientsList")]
        public async Task<IActionResult> Index()
        {
            var listPatients = await patientsRepository.getAllPatients();
            return await Task.Run(() => View(listPatients));
        }

        [Route("DoctorPanel/AddPatients")]
        public async Task<IActionResult> insertData()
        {
            return await Task.Run(() => View());
        }

        [HttpPost("DoctorPanel/insertPatients")]
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

        [Route("DoctorPanel/editPatients/{id}")]
        public async Task<IActionResult> updateData(int id)
        {
            var data = await patientsRepository.getPatientsById(id);
            return View(data);
        }

        [HttpPost("DoctorPanel/UpdatePatients")]
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


        [HttpPost("DoctorPanel/DeletePatients/{id}")]
        public async Task<IActionResult> deleteData(int id)
        {
            var result = await patientsRepository.deletePatients(id);

            if (result == true)
            {
                await patientsRepository.saveChanges();
            }

            return Json("/DoctorPanel/PatientsList");
        }
    }
}