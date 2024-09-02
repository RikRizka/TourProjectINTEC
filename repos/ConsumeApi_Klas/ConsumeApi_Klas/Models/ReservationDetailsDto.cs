using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApi_Klas.Models
{
    internal class ReservationDetailsDto
    {
        public int ReservationId { get; set; }
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public int TableId { get; set; }
        public DateTime DateTime { get; set; }
        public SpecialRequests SpecialRequests { get; set; }
    }
}
