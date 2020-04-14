using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ApplicationUser
{
    public class ApplicationUser : IdentityUser
    {
        public int nationalNumber { get; set; }
        public string userName { get; set; }
    }
}
