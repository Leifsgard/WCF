using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Services;

namespace WCF
{
    /// <summary>
    /// Summary description for NameDate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDate : System.Web.Services.WebService
    {

        [WebMethod]
        public string PrintDateForName(string nameInput)
        {
            var nameDays = File.ReadAllLines(@"C:\Users\Rasmus\Desktop\WCF\WCF\WCF\NameDays.txt");
            var date = "";
            foreach (var nameSplit in nameDays.Select(nameDay => nameDay.Split(' ')).Where(nameSplit => nameSplit.Contains(nameInput)))
            {
                date = nameSplit[0] + " " + nameSplit[1];
            }
            return date;
        }
    }
}
