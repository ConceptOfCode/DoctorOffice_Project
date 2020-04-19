using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DoctorOffice.DataLayer;
using DoctorOffice_Project.Areas.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Identity;
using DoctorOffice_Project.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using DoctorOffice.ApplicationUser;
using DoctorOffice.Services;
using System.Net;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Authorize(Roles = "secretary, doctor")]
    [Area("secretaryPanel")]
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private ApplicationDbContext dbContext;
        private readonly IAuthorizationRepository authorizationRepository;
        public HomeController(
            Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext DB,
            IAuthorizationRepository authorization)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender; this.dbContext = DB;
            this.authorizationRepository = authorization;
        }

        [Route("secretaryPanel")]
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        [Route("Clinic/UserRoles")]
        public async Task<IActionResult> createUsers()
        {
            #region oldCode
            //var user = new IdentityUser();
            //user.UserName = "me.@gmail.com";
            //user.EmailConfirmed = true;
            //user.Email = "me.@gmail.com";
            //user.NormalizedEmail = "me.@gmail.com".ToUpper();
            //user.NormalizedUserName = "me.@gmail.com".ToUpper();
            //user.PasswordHash = "AQAAAAEAACcQAAAAEGjOg+BvbdEUsF7eaaNvpIcL0GKk5iZH+O9MclYVcNVeT9jFqH8m0320OqcQsl/tFw==";

            //await db.Users.AddAsync(user);
            //await db.SaveChangesAsync();

            //var UserLastID = user.Id;

            //var roles = new IdentityRole();
            //roles.Name = "secretary";
            //roles.NormalizedName = "secretary".ToUpper();

            //await dbContext.Roles.AddAsync(roles);
            //await dbContext.SaveChangesAsync();

            //var RoleLastID = roles.Id;

            //var userRoles = new IdentityUserRole<string>();
            //userRoles.UserId = UserLastID;
            //userRoles.RoleId = RoleLastID;

            //await db.UserRoles.AddAsync(userRoles);
            //await db.SaveChangesAsync();

            // await CreateUserRoles(service);

            //await CreateRoles();
            #endregion

            var role = await authorizationRepository.getAllRoles();
            return await Task.Run(() => View(role));
        }

        [HttpGet("checkUserBeforCreate/{email}")]
        public async Task<bool> findUser(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost("createUsers")]
        public async Task<IActionResult> CreateUsers(IdentityUser identityUser, string Password, string Role)
        {
            #region oldCode
            //var adminRole = "doctor";

            //// administrator
            //var user = new IdentityUser
            //{
            //    UserName = "sm@gmail.com",
            //    Email = "sm@gmail.com",
            //    EmailConfirmed = true
            //};
            //var i = await _userManager.FindByEmailAsync(user.Email);
            //if (i == null)
            //{
            //    var adminUser = await _userManager.CreateAsync(user, "asd@ASD123");
            //    if (adminUser.Succeeded)
            //    {

            //        await _userManager.AddToRoleAsync(user, adminRole);
            //        //
            //        _logger.LogInformation("Create {0}", user.UserName);
            //    }
            //}
            #endregion

            var UserResult = await authorizationRepository.createUser(identityUser, Password);
            if (UserResult.Succeeded)
            {
                var userCreated = await _userManager.FindByEmailAsync(identityUser.Email);
                await authorizationRepository.userBindToRole(userCreated, Role);
            }
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        [Route("Logout")]
        public async Task<IActionResult> Logout(string returnUrl = "")
        {
            foreach (var item in HttpContext.Request.Cookies.Keys)
            {
                await Task.Run(() => Response.Cookies.Delete(item));
            }

            if (returnUrl == "/doctorPanel")
            {
                return RedirectToAction("Index", "Home", new { area = "doctorPanel" });
            }
            if (returnUrl == "/patientsPanel")
            {
                return RedirectToAction("Index", "Home", new { area = "patientsPanel" });
            }

            return RedirectToAction("Index");
        }
    }
}
