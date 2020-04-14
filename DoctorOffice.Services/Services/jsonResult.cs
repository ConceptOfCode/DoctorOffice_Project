using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorOffice.Services
{
    public class jsonResult
    {
        public int statusCode { get; set; }
        public string statusText { get; set; }
        public string returnUrl { get; set; }
        public string responseText { get; set; }

        public static jsonResult GetJsonResult(int statusCode, string statusText, string returnURL, string responseText)
        {
            return new jsonResult()
            {
                statusCode = statusCode,
                statusText = statusText,
                returnUrl = returnURL,
                responseText = responseText
            };
        }
    }
}
