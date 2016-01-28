using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WCF
{
    /// <summary>
    /// Summary description for PeopleWhoPassedAway2010
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PeopleWhoPassedAway2010 : System.Web.Services.WebService
    {

        [WebMethod]
        public string PersonWhoPassedAway(string date)
        {
            var persons = File.ReadAllLines(@"C:\Users\Rasmus\Desktop\WCF\WCF\WCF\Resources\PeopleThatPassedAway2010.txt");
            var person = "";
            foreach (var personsplit in persons.Select(personsplit => personsplit.Split(':')).Where(personsplit => personsplit.Contains(date)))
            {
                person = personsplit[1];
            }
                return person;
        }
    }
}
