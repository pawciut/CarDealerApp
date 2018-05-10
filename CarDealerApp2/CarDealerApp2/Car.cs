using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp2
{
    public class Car
    {
        public CarType Marka { get; set; }
        public int Rocznik { get; set; }
        public EngineType TypSilnika { get; set; }
        public decimal Cena { get; set; }

       




        public void Wypisz()
        {

            //Console.WriteLine("Marka: " + Marka, "Rocznik: " + Rocznik, "Typ Silnika" + TypSilnika, "Cena: " + Cena);
            Console.WriteLine("Marka: {0}, Rocznik: {1}, Typ silnika: {2}, Cena: {3}", Marka, Rocznik, TypSilnika, Cena);

            Console.WriteLine();
        }



        public Car(CarType car, int year, EngineType E, int price) //konstruktor w z 4 parametrami które muszą być przekazane
        {
            Marka = car;
            Rocznik = year;
            TypSilnika = E;
            Cena = price;


        }

        public Car()//konstruktor bez parametrowy
        {
            Marka = CarType.Fiat;
            Rocznik = 2010;
            TypSilnika = EngineType.Diezel;
            Cena = 15000;


        }

        public Car(CarType car)//konstruktor z 1 parametrem do przekazania
        {
            Marka = car;
            Rocznik = 9999;
            TypSilnika =EngineType.Inny;
            Cena = 7000;



        }


    }
}
