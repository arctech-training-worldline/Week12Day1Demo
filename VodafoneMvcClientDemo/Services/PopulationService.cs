using AkshayPopulationServiceReference;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace VodafoneMvcClientDemo.Services
{
    public class PopulationService : IPopulationService
    {
        public readonly string serviceUrl = "https://localhost:44309/PopulationLive.asmx";
        public readonly EndpointAddress endpointAddress;
        public readonly BasicHttpBinding basicHttpBinding;        

        public PopulationService()
        {
            endpointAddress = new EndpointAddress(serviceUrl);

            basicHttpBinding = new BasicHttpBinding(
                endpointAddress.Uri.Scheme.ToLower() == "http" ?
                    BasicHttpSecurityMode.None :
                    BasicHttpSecurityMode.Transport)
            {
                OpenTimeout = TimeSpan.MaxValue,
                CloseTimeout = TimeSpan.MaxValue,
                ReceiveTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue
            };
        }

        private readonly UserAuthSoapHeader userAuth = new UserAuthSoapHeader
        {
            Username = "raman",
            Password = "gujral@123"
        };

        public async Task<int> GetTotalPopulationAsync(string city)
        {
            var client = new PopulationLiveSoapClient(basicHttpBinding, endpointAddress);

            //var soapResponse = await client.GetTotalPopulationAsync(city);
            //return soapResponse.Body.GetTotalPopulationResult;

            var soapResponse = await client.GetTotalPopulationAsync(userAuth, city);
            return soapResponse.GetTotalPopulationResult;
        }

        public async Task<PopulationInfo> GetPopulationInfoAsync(string city)
        {
            var client = new PopulationLiveSoapClient(basicHttpBinding, endpointAddress);

            //var soapResponse = await client.GetPopulationInfoAsync(city);
            //return soapResponse.Body.GetPopulationInfoResult;

            var soapResponse = await client.GetPopulationInfoAsync(userAuth, city);
            return soapResponse.GetPopulationInfoResult;
        }
    }
}
