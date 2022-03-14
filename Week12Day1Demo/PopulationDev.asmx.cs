using System;
using System.Web.Services;

namespace Week12Day1Demo
{
    /// <summary>
    /// Summary description for PopulationDev
    /// </summary>
    [WebService(Namespace = "http://akshay.com/populationservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PopulationDev : System.Web.Services.WebService
    {
        [WebMethod]
        public int GetTotalPopulation(string city)
        {
            var random = new Random();
            return random.Next(100);
        }

        [WebMethod]
        public PopulationInfo GetPopulationInfo(string city)
        {
            var random = new Random();
            return new PopulationInfo
            {
                Males = random.Next(100),
                Females = random.Next(100),
                Others = random.Next(100),
                Below18 = random.Next(100),
                Above65 = random.Next(100),
            };
        }
    }
}
