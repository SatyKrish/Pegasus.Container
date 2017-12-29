using PegasusDataStore.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PegasusDataStore.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> GetByBookingReferenceAsync(string bookingReference);
        Task<IEnumerable<Booking>> GetByTripReferenceAsync(string tripReference);
        Task<string> AddAsync(Booking booking);
        Task ConfirmAsync(Booking booking);
        Task CancelAsync(Booking booking);
    }
}