using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Ticket
    {
        public string Name { get; set; }
        public string DefectType { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Batch { get; set; }
        public int Station { get; set; }

    }
}
