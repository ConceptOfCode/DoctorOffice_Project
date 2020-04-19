using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Services;
using DoctorOffice.DataLayer;
using DoctorOffice.Enums;
using DoctorOffice.Domains;
using constantConcepts = DoctorOffice.Enums.constantConcepts;
using DoctorOffice.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class ProfileController : Controller
    {
        IEmployeesRepository employeesRepository;
        public ProfileController(IEmployeesRepository employees)
        {
            this.employeesRepository = employees;
        }

        [Route("Clinic/Profile")]
        public async Task<IActionResult> Index()
        {
            var data = await employeesRepository.getEmployeeByEmail(User.Identity.Name);
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

        [HttpGet("checkBeforeInsertEmployee/{nationalID}/{Email}")]
        public async Task<bool> checkBeforeInsert(int nationalID, string Email)
        {
            var findNationalID = await employeesRepository.isExistsEmployeeByNationalID(nationalID);
            var findEmail = await employeesRepository.isExistsEmployeeByEmail(Email);

            if (findNationalID == false && findEmail == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("checkBeforeUpdateEmployee/{empID}/{nationalID}/{Email}")]
        public async Task<bool> checkBeforeUpdate(int empID, int nationalID, string Email)
        {
            var EmailResult = await employeesRepository.checkEmail(empID, Email);
            var nationalIdResult = await employeesRepository.checkNationalID(empID, nationalID);

            if (EmailResult == true && nationalIdResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost("InsertEmployee")]
        public async Task<IActionResult> insertData(Employees employees, IFormFile imgUp, string returnUrl = "")
        {
            if (returnUrl == "/DoctorPanel/Profile")
            {
                employees.Type = (int)constantConcepts.EmployeeType.doctor;
            }
            employees.createDate = DateTime.Now.toShamsi();

            if (imgUp != null)
            {
                employees.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                string savePath = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/uploadImages", employees.imageName
                );

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imgUp.CopyToAsync(stream);
                }

            }

            var result = await employeesRepository.insertEmployee(employees);
            if (result == true)
            {
                await employeesRepository.saveChanges();
            }

            if (returnUrl != "" || returnUrl != null)
            {
                return RedirectToAction(returnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> updateData(Employees employees, IFormFile imgUp, string returnUrl = "")
        {
            if (imgUp != null)
            {
                if (employees.imageName == null)
                {
                    employees.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
                }

                string savePath = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/uploadImages", employees.imageName
                );

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imgUp.CopyToAsync(stream);
                }

            }

            employees.Type = (int)constantConcepts.EmployeeType.secretary;
            employees.createDate = DateTime.Now.toShamsi();

            var result = await employeesRepository.editEmployee(employees);
            if (result == true)
            {
                await employeesRepository.saveChanges();
            }

            if (returnUrl == "/DoctorPanel/Profile")
            {
                return RedirectToAction("Index", "Profile", new { area = "doctorPanel" });
            }

            return RedirectToAction("Index");
        }
    }
}