using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatışOtomasyonu.Models
{
    public class Session
    {
        public string date  { get; set; }
        public string time { get; set; }
        public List<Chair> chairs { get; set; }


    }
}
