using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> ListaSamochodow = new List<Car>();//tworzymy Listę obiektów  typu Car którą wywołuje konstruktor new List<Car>
            ListaSamochodow.Add(new Car("Ford ", 2005, "Benzyna ", 4000));
            ListaSamochodow.Add(new Car("BMW ", 2008, "Dizel ", 5000));
            
            foreach (Car iCar in ListaSamochodow) //dla każdego iCar typu Car z ListySamochodow
            {
                Console.WriteLine("LISTA SAMOCHODOW:");
                Console.WriteLine("Marka: " + iCar.Marka + 
                    "\nRocznik: " + iCar.Rocznik +
                    "\nTyp Silnika: " + iCar.TypSilnika +
                    "\nCena: " + iCar.Cena + "PLN");
                //wypisz właściwość iCar z Listy (na liscie mamy 2 obiekty)
            }




            Car Car1 = new Car();
            Car Car2 = new Car("Audi");
            Car Car3 = new Car("Kia", 2008, "Diezel", 4000);
            Car1.Wypisz();
            Car2.Wypisz();
            Car3.Wypisz();

            Console.ReadKey();
        }
    }
}
