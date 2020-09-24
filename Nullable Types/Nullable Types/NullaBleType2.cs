using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    public class NullaBleType2
    {
        public void Nullable()
        {
            int AvailableTickets;
            int? TicketsOnSale = null;

            //without null coalescing operator
            /*
            if (TicketsOnSale == null)
                AvailableTickets = 0;
            else
                AvailableTickets = TicketsOnSale.Value;

            Console.WriteLine("Availabe tickets = {0}", AvailableTickets);
            */

            //with null coalescing operator
            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Availabe tickets = {0}", AvailableTickets);
        }
    }
}
