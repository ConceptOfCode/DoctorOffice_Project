using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DoctorOffice.ExtensionMethods
{
    public static class shamsiDate
    {
        public static string toShamsi(this DateTime dateTime)
        {
            var pc = new PersianCalendar();

            return pc.GetYear(dateTime).ToString() + "/" + pc.GetMonth(dateTime).ToString("00") + "/" + pc.GetDayOfMonth(dateTime).ToString("00");
        }
    }
}
