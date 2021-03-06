﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PegasusDataStore.Documents;
using System;

namespace PegasusDataStore.Interfaces
{
    public interface ITripRepository
    {
        Task<Trip> GetByTripReferenceAsync(string tripReference);
        Task<IEnumerable<Trip>> GetByTripDetailsAsync(string fromCity, string toCity, string journeyDate);
        Task<string> AddAsync(Trip trip);
        Task UpdateAsync(Trip trip);
        Task ResetAsync(Trip trip);
    }
}
