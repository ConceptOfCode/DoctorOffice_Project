using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ExtensionMethods
{
    public static class ToDateTime
    {
        public static DateTime toDate(this string Content)
        {
            var yourDate = Content.Split('/');
            var Date = new DateTime(int.Parse(yourDate[0]), int.Parse(yourDate[1]), int.Parse(yourDate[2]));
           
            return Date;
        }
    }
}
