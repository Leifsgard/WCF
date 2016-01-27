﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF
{
    /// <summary>
    /// Summary description for addtwonumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class addtwonumbers : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddTwoNumbers(string firstNumber, string secondNumber)
        {
            var sum = int.Parse(firstNumber) + int.Parse(secondNumber);
            return sum;
        }
    }
}
