using AkshayPopulationServiceReference;
using System.Threading.Tasks;

namespace VodafoneMvcClientDemo.Services
{
    public interface IPopulationService
    {
        Task<PopulationInfo> GetPopulationInfoAsync(string city);
        Task<int> GetTotalPopulationAsync(string city);
    }
}