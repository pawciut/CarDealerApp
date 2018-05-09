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


            Console.WriteLine("Marka: {0}, Rocznik: {1}, Typ silnika: {2}, Cena: {3}", Marka, Rocznik, TypSilnika, Cena);

            Console.WriteLine();
        }

        

        public Car(string Car, int Year, string E, int Price) //konstruktor w z 4 parametrami które muszą być przekazane
        {
            Marka = Car;
            Rocznik = Year;
            TypSilnika = E;
            Cena = Price;

            
        }

        public Car()//konstruktor bez parametrowy
        {
            Marka = "Fiat Punto";
            Rocznik = 2005;
            TypSilnika = "Benzyna";
            Cena = 6000;

            
        }

        public Car(string Car)//konstruktor z 1 parametrem do przekazania
        {
            Marka = Car;
            Rocznik = 2007;
            TypSilnika = "Benzyna";
            Cena = 7000;

            

        }
        
    }
}
