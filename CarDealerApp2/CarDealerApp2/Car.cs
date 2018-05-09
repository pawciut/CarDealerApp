using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp2
{
    public class Car
    {
        public string Marka { get; set; } //tworzymy własciwości
        public int Rocznik { get; set; }
        public string TypSilnika { get; set; }
        public int Cena { get; set; }


        public void Wypisz()
        {
            Console.WriteLine("Marka: " + this.Marka, "Rocznik: " + this.Rocznik, "Typ Silnika: " + this.TypSilnika, "Cena: " + this.Cena);
        }

        public Car(string Car, int Year, string E, int Price) //tworzymy konstruktor w z 4 parametrami które muszą być przekazane
        {
            Marka = Car;
            Rocznik = Year;
            TypSilnika = E;
            Cena = Price;
        }

        public Car()
        {
            Marka = "Fiat Punto";
            Rocznik = 2005;
            TypSilnika = "Benzyna";
            Cena = 4000;
        }

        public Car(string Car)
        {
            Marka = Car;
            Rocznik = 2005;
            TypSilnika = "Benzyna";
            Cena = 4000;

        }
    }
}
