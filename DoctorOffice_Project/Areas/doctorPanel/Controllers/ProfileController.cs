using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.Enums;
using DoctorOffice.ExtensionMethods;
using DoctorOffice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using constantConcepts = DoctorOffice.Enums.constantConcepts;

namespace DoctorOffice_Project.Areas.doctorPanel.Controllers
{
    [Authorize(Roles = "doctor")]
    [Area("doctorPanel")]
    public class ProfileController : Controller
    {
        IEmployeesRepository employeesRepository;
        public ProfileController(IEmployeesRepository employees)
        {
            this.employeesRepository = employees;
        }

        [Route("DoctorPanel/Profile")]
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
            return await Task.Run(() => View(data));
        }

        //[HttpGet("checkBeforeInsertEmployee/{nationalID}/{Email}")]
        //public async Task<bool> checkBeforeInsert(int nationalID, string Email)
        //{
        //    var findNationalID = await employeesRepository.isExistsEmployeeByNationalID(nationalID);
        //    var findEmail = await employeesRepository.isExistsEmployeeByEmail(Email);

        //    if (findNationalID == false && findEmail == false)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //[HttpGet("checkBeforeUpdateEmployee/{empID}/{nationalID}/{Email}")]
        //public async Task<bool> checkBeforeUpdate(int empID, int nationalID, string Email)
        //{
        //    var EmailResult = await employeesRepository.checkEmail(empID, Email);
        //    var nationalIdResult = await employeesRepository.checkNationalID(empID, nationalID);

        //    if (EmailResult == true && nationalIdResult == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //[HttpPost("InsertEmployee")]
        //public async Task<IActionResult> insertData(Employees employees, IFormFile imgUp)
        //{
        //    employees.Type = (int)constantConcepts.EmployeeType.secretary;
        //    employees.createDate = DateTime.Now.toShamsi();

        //    if (imgUp != null)
        //    {
        //        employees.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
        //        string savePath = Path.Combine(
        //            Directory.GetCurrentDirectory(), "wwwroot/uploadImages", employees.imageName
        //        );

        //        using (var stream = new FileStream(savePath, FileMode.Create))
        //        {
        //            await imgUp.CopyToAsync(stream);
        //        }

        //    }

        //    var result = await employeesRepository.insertEmployee(employees);
        //    if (result == true)
        //    {
        //        await employeesRepository.saveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}

        //[HttpPost("UpdateEmployee")]
        //public async Task<IActionResult> updateData(Employees employees, IFormFile imgUp)
        //{
        //    if (imgUp != null)
        //    {
        //        if (employees.imageName == null)
        //        {
        //            employees.imageName = Guid.NewGuid().ToString() + Path.GetExtension(imgUp.FileName);
        //        }

        //        string savePath = Path.Combine(
        //            Directory.GetCurrentDirectory(), "wwwroot/uploadImages", employees.imageName
        //        );

        //        using (var stream = new FileStream(savePath, FileMode.Create))
        //        {
        //            await imgUp.CopyToAsync(stream);
        //        }

        //    }

        //    employees.Type = (int)constantConcepts.EmployeeType.secretary;
        //    employees.createDate = DateTime.Now.toShamsi();

        //    var result = await employeesRepository.editEmployee(employees);
        //    if (result == true)
        //    {
        //        await employeesRepository.saveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}