using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.DataLayer;
using Microsoft.AspNetCore.Identity;
using DoctorOffice_Project.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using DoctorOffice.Services;
using DoctorOffice.Domains;
using System.IO;
using Microsoft.AspNetCore.Http;
using DoctorOffice.ExtensionMethods;

namespace DoctorOffice_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IAuthorizationRepository authorizationRepository;
        IPatientsRepository patientsRepository;
        ITemporaryPatientsRepository temporaryPatientsRepository;
        ITurnsRepository turnsRepository;

        public HomeController(
            Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IAuthorizationRepository authorization, IPatientsRepository patients, ITemporaryPatientsRepository temporaryPatients, ITurnsRepository turns)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this.authorizationRepository = authorization;
            this.patientsRepository = patients;
            this.temporaryPatientsRepository = temporaryPatients;
            this.turnsRepository = turns;
        }

        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        [Route("NewPatients")]
        public async Task<IActionResult> createPatients()
        {
            return await Task.Run(() => View());
        }

        [HttpPost]
        public async Task<IActionResult> createPatients(patients patients, string Password, string confpassword, IFormFile imgUp)
        {
            var newUser = new IdentityUser()
            {
                Email = patients.Email,
                UserName = patients.Email
            };
            if (Password == confpassword)
            {
                var UserResult = await authorizationRepository.createUser(newUser, Password);
                if (UserResult.Succeeded)
                {
                    var userCreated = await _userManager.FindByEmailAsync(newUser.Email);
                    await authorizationRepository.userBindToRole(userCreated, "patients");

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
                }
            }

            return Redirect("/Identity/Account/Login?ReturnUrl=");
        }

        [Route("Login")]
        public async Task<IActionResult> Login()
        {
            return await Task.Run(() => View());
        }

        [Route("AboutUs")]
        public async Task<IActionResult> aboutUs()
        {
            return await Task.Run(() => View());
        }

        [Route("Reserve")]
        public async Task<IActionResult> TemporaryReserve()
        {
            return await Task.Run(() => View());
        }

        [HttpPost]
        public async Task<IActionResult> TemporaryReserve(Temporarypatients temporarypatients, int employeeID, string reserveDate, string Descriptions)
        {
            temporarypatients.createDate = DateTime.Now.toShamsi();
            var TemporaryResult = await temporaryPatientsRepository.insertTemporaryPatients(temporarypatients);
            if (TemporaryResult)
            {
                await temporaryPatientsRepository.saveChanges();
            }

            var lastID = temporarypatients.temporaryPatientsID;
            var turn = new Turns()
            {
                temporaryPatientsID = lastID,
                employeeID = employeeID,
                reserveDate = reserveDate,
                Descriptions = Descriptions,
                createDate = DateTime.Now.toShamsi(),
                statusTurn = 1
            };

            var turnsResult = await turnsRepository.insertTurns(turn);
            if (turnsResult)
            {
                await turnsRepository.saveChanges();
            }

            return RedirectToAction("TemporaryReserve");
        }
    }
}
