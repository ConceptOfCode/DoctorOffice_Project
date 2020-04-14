using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface IAuthorizationRepository : IDisposable
    {
        Task<IdentityResult> createUser(IdentityUser user, string password);
        Task<bool> userBindToRole(IdentityUser user, string role);
        Task<bool> disableUser(string email);
        Task<IEnumerable<IdentityRole>> getAllRoles();
    }
}
