using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF
{
    /// <summary>
    /// Summary description for WeatherForecastService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherForecastService : System.Web.Services.WebService
    {

        [WebMethod]
         public string PrintForecast()
         {
             var random = new Random();
             var range = random.Next(0, 5);
 
             var arrayOfSentences = new string[5];
             arrayOfSentences[0] = "Tomorrow it will be cold";
             arrayOfSentences[1] = "Tomorrow it will be hot";
            arrayOfSentences[2] = "Tomorrow there will be no weather";
             arrayOfSentences[3] = "Tomorrow it will be sunny and rainy at the same time";
             arrayOfSentences[4] = "Tomorrow, there will be total darkness.";
             var stringPrint = arrayOfSentences[range];
             return stringPrint;
         }
     }
}
