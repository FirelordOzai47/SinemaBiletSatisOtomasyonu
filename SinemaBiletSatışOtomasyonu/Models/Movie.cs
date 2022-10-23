using SinemaBiletSatışOtomasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatışOtomasyonu.Models
{
    public class Movie:BaseClass
    {
        public string picturePath { get; set; }
        public string munite { get; set; }
        public decimal price { get; set; }
        public Category category { get; set; }
        public List<Session> sessions { get; set; }

    }
}
