using Pojazdy;
using System.Diagnostics;
using System.Xml.Linq;

namespace myLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czasopismo czasopismo = new Czasopismo()
            {
                name = "Klio",
                genre = "Czasopismo",
                releaseDate = new DateTime(2023, 11, 24),
                autor = "Uniwersytet Mikołaja Kopernika w Toruniu",
                theme = "Historia",
                price = 14,
            };
            czasopismo.ShowInfo();

            Podrecznik podrecznik = new Podrecznik()
            {
                name = "Cambridge Lower Secondary Mathematics",
                genre = "Czasopismo",
                releaseDate = new DateTime(2021, 03, 07),
                autor = "Lynn Byrd, Greg Byrd, Chris Pearce",
                subject = "Mathematics",
                level = "Intermediate",
                language = "English",
                price = 34,
            };
            podrecznik.ShowInfo();

            Powiesc powiesc = new Powiesc()
            {
                name = "Wyspa skarbów",
                genre = "Powiesc",
                releaseDate = new DateTime(1883,01,23),
                autor = "Robert Stevenson",
                pagesCount = 312,
                price = 7,
            };
            powiesc.ShowInfo();


        }
    }
}
