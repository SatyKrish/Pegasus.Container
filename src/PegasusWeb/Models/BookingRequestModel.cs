using System.Collections.Generic;

namespace PegasusWeb.Models
{
    public class BookingRequestModel
    {
        public string TripReference { get; set; }
        public IEnumerable<string> Seats { get; set; }
    }
}