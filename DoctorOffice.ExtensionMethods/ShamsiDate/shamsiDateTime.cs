using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DoctorOffice.ExtensionMethods
{
    public static class shamsiDateTime
    {
        public static string toShamsiDateTime(this DateTime dateTime)
        {
            PersianCalendar SB = new PersianCalendar();
            return SB.GetYear(dateTime).ToString() + "/" + SB.GetMonth(dateTime).ToString("00") + "/" + SB.GetDayOfMonth(dateTime).ToString("00") +
                "$$" + SB.GetHour(dateTime).ToString("00") + ":" + SB.GetMinute(dateTime).ToString("00") + ":" + SB.GetSecond(dateTime).ToString("00");
        }
    }
}
