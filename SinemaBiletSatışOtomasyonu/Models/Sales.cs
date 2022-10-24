using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatışOtomasyonu.Models
{
    internal class Sales : BaseClass
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} Adlı Filmin {sessionTime}  seansına {count} adet bilet satın alma işlemi gerçekleşmiştir.\n Toplam tutar ={totalPrice} TL \n Satın Alınma Tarihi {creationDate} ";
        }
    }
}
