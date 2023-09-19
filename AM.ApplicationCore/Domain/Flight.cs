using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Flight
    {
        public Flight(string departure, string destination, DateTime effectiveArrival, string estimatedDuration, DateTime flightDate, int flightId)
        {
            Departure = departure;
            Destination = destination;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
            FlightDate = flightDate;
            FlightId = flightId;
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime EffectiveArrival { get; set; }

        public string EstimatedDuration { get; set; }

        public DateTime FlightDate { get; set; }

        public int FlightId { get; set; }


    }
}
