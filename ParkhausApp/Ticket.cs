using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausApp
{
     public class Ticket
    {
        public Ticket() { }

        public int TicketNumber { get; set; }
        public decimal Price { get; set; }
        public DateTime EntryTime { get; set; }
        public bool IsPaid { get; set; }



        }
        
        
    }

