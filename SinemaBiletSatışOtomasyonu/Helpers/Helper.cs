using SinemaBiletSatışOtomasyonu.Enums;
using SinemaBiletSatışOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatışOtomasyonu.Helpers
{
    internal class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/MustafaDogan/Desktop/Visual Studio Denemeler/SinemaBiletSatışOtomasyonu/SinemaBiletSatışOtomasyonu/Pictures/";

            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Kapışma",
                    category = Category.gerilim,
                    munite = "2 Saat 10 Dakika",
                    price =60,
                    picturePath = basePath +"Kapışma.jpg"

                },
                new Movie()
                {
                     movieName = "The God Father",
                    category = Category.macera,
                    munite = "2 Saat 50 Dakika",
                    price =70,
                    picturePath = basePath +"baba.jpg"

                },
                 new Movie()
                {
                      movieName = "Geçmişin Gölgesinde",
                    category = Category.gerilim,
                    munite = "2 Saat 10 Dakika",
                    price =50,
                    picturePath = basePath +"geçmiş.jpg"
                },
                  new Movie()
                {
                      movieName = "Hobbit",
                    category = Category.fantastik,
                    munite = "3 saat",
                    price =50,
                    picturePath = basePath +"hobbit.jpeg"
                },
                   new Movie()
                {
                       movieName = "Yan Komşum Totoro",
                    category = Category.bilim_kurgu,
                    munite = "1 saat 10 Dakika",
                    price =40,
                    picturePath = basePath +"totoro.jpg"
                },
                    new Movie()
                {
                        movieName = "Yüzüklerin Efendisi",
                    category = Category.macera,
                    munite = "2 Saat 40 Dakika",
                    price =70,
                    picturePath = basePath +"yüzük.jpg"
                }



            };
        }
    }
}
