using AM.ApplicationCore.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class BasicFlightService : IBasicFlightService

    {
        public ICollection source;
        public BasicFlightService(ICollection source) { 

            this.source = source;


        }

        public void ShowFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    foreach (Flight flight in source)
                    {
                        if ( flight.Destination == filterValue)
                        {
                         Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight flight in source)
                    {
                        if (  flight.FlightDate == DateTime.Parse (filterValue))
                        {
                            Console.WriteLine(flight);
                        }

                    }
                    break;

                case "FlightId":
                    foreach (Flight flight in source)
                    {
                        if (flight.FlightId == int.Parse(filterValue)){

                            Console.WriteLine(flight);

                        }

                    }
                    break;
                default: throw new ArgumentException("Unknown Filter");



            }
        }
    }
}
