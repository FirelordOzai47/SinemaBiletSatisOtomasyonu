using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatışOtomasyonu.Models
{
    internal class Sales : BaseClass
    {
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }
        public string sessionTime { get; set; }

    }
}
