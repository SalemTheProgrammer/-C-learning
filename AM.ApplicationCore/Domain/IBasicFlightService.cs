using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal interface IBasicFlightService
    {
        public void ShowFlights(string filterType, string filterValue);
       
    }
}
