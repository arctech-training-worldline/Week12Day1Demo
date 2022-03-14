using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using Week12Day1Demo.Models;

namespace Week12Day1Demo
{
    /// <summary>
    /// Summary description for PopulationLive
    /// </summary>
    [WebService(Namespace = "http://akshay.com/populationservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PopulationLive : System.Web.Services.WebService
    {
        [WebMethod]
        [SoapHeader(nameof(UserAuthSoapHeader))]
        public int GetTotalPopulation(string city)
        {
            AuthenticateUser();

            var random = new Random();
            return random.Next(999999);
        }

        public UserAuthSoapHeader UserAuthSoapHeader { get; set; }

        [WebMethod]
        [SoapHeader(nameof(UserAuthSoapHeader))]
        public PopulationInfo GetPopulationInfo(string city)
        {
            AuthenticateUser();

            var random = new Random();
            return new PopulationInfo
            {
                Males = random.Next(999999),
                Females = random.Next(999999),
                Others = random.Next(999999),
                Below18 = random.Next(999999),
                Above65 = random.Next(999999),
            };
        }

        private void AuthenticateUser()
        {
            if (UserAuthSoapHeader == null)
                throw new SoapHeaderException(
                    "Soap Header [UserAuthSoapHeader] is missing!!"
                    , new XmlQualifiedName(nameof(UserAuthSoapHeader)));

            if (!UserAuthSoapHeader.IsValid())
                throw new SoapHeaderException(
                    "Username and/or password is invalid!!"
                    , new XmlQualifiedName(nameof(UserAuthSoapHeader)));
        }
    }
}
