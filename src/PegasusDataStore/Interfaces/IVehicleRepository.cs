using PegasusDataStore.Documents;
using System.Threading.Tasks;

namespace PegasusDataStore.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetByVinAsync(string vin);
        Task AddAsync(Vehicle vehicle);
        Task UpdateAsync(Vehicle vehicle);
    }
}