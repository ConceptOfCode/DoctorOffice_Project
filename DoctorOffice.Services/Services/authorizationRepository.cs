using DoctorOffice.DataLayer;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;

namespace DoctorOffice.Services
{
    public class authorizationRepository : IAuthorizationRepository
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext db;

        public authorizationRepository(
            Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext DB)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this.db = DB;
        }

        public async Task<IdentityResult> createUser(IdentityUser user, string password)
        {
            try
            {
                var identityResult = IdentityResult.Failed();
                var newUser = new IdentityUser
                {
                    UserName = user.Email,
                    Email = user.Email,
                    EmailConfirmed = true
                };
                var find = await _userManager.FindByEmailAsync(user.Email);
                if (find == null)
                {
                    identityResult = await _userManager.CreateAsync(newUser, password);
                }
                return identityResult;
            }
            catch (Exception)
            {

                return IdentityResult.Failed();
            }
        }

        public async Task<bool> userBindToRole(IdentityUser user, string role)
        {
            try
            {
                //var find = await _userManager.FindByEmailAsync(user.Email);

                await _userManager.AddToRoleAsync(user, role);
                _logger.LogInformation("Create {0}", user.UserName);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> disableUser(string email)
        {
            try
            {
                var find = await _userManager.FindByEmailAsync(email);
                find.EmailConfirmed = false;
                await _userManager.UpdateAsync(find);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async void Dispose()
        {
            await this.db.DisposeAsync();
        }

        public async Task<IEnumerable<IdentityRole>> getAllRoles()
        {
            return await Task.Run(() => db.Roles);
        }
    }
}
