using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.ExtensionMethods
{
    public static class emptyOrNull
    {
        public static bool IsEmptyOrNull(this string Content)
        {
            if (Content == "" || Content == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEmptyOrNull(this int? Content)
        {
            if (Content == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
