using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.Enums
{
    public partial class constantConcepts
    {
        public enum human
        {
            men = 4,
            women = 5
        }

        public enum Status
        {
            success = 1,
            error = 2,
            danger = 3,
            warning = 4
        } 

        public enum Roles
        {
            admin,
            doctor,
            secretary,
            patients
        }

        public enum EmployeeType
        {
            doctor = 1,
            secretary = 2
        }

        public enum dayOfWeek
        {
            saturday = 6,
            sunday = 7,
            monday = 8,
            tuesday = 9,
            wensday = 10,
            thursday = 11,
            friday = 12
        }

        public enum isActive
        {
            enable = 1,
            disable = 2
        }

        public enum httpStatus
        {
            notFound = 404,
            unauthorized = 401,
            badRequest = 400,
            forbidden = 403,
            internalServerError = 500,
            successed = 200
        }

        public enum month
        {
            farvardin = 13,
            ordibehesht = 14,
            khordad = 15,
            tir = 16,
            mordad = 17,
            shahrivar = 18,
            mehr = 19,
            aban = 20,
            azar = 21,
            dey = 22,
            bahman = 23,
            esfand = 24
        }

    }
}
