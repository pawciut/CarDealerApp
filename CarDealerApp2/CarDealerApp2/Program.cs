using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp2
{
    class Program
    {
         static List<Car> ListaSamochodow = new List<Car>();
        static void Main(string[] args)
        {

            //List<Car> ListaSamochodow = new List<Car>();
            
            ListaSamochodow.Add(new Car(CarType.Fiat, 2005, EngineType.Benzyna, 4000));
            ListaSamochodow.Add(new Car(CarType.BMW, 2008, EngineType.Diezel, 5000));
            //ListaSamochodow.Add(new Car());
            //ListaSamochodow.Add(new Car(CarType.BMW));
            //ListaSamochodow.Add(new Car(CarType.Fiat, 2008, EngineType.Diezel, 9000));

            //foreach (Car iCar in ListaSamochodow) //dla każdego iCar typu Car z ListySamochodow
            //{
            //    Console.WriteLine("LISTA SAMOCHODOW:");
            //    Console.WriteLine("Marka: " + iCar.Marka +
            //        "\nRocznik: " + iCar.Rocznik +
            //        "\nTyp Silnika: " + iCar.TypSilnika +
            //        "\nCena: " + iCar.Cena + "PLN");
            //    wypisz właściwość iCar z Listy(na liscie mamy 2 obiekty)
            //}
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            

            ShowConstructorAction();
            foreach (Car xCar in ListaSamochodow)
            {
                xCar.Wypisz();
            }
            //RandomCar();
            Console.ReadKey();
        }
        public static void ShowConstructorAction()

        {
            Car Car1 = new Car();
            Car Car2 = new Car(CarType.BMW);
            Car Car3 = new Car(CarType.Fiat, 2008, EngineType.Diezel, 4000);


            

            ListaSamochodow.Add(Car1);
            ListaSamochodow.Add(Car2);
            ListaSamochodow.Add(Car3);

            //Car1.Wypisz();
            //Car2.Wypisz();
            //Car3.Wypisz();


            
        }
        //public static void RandomCar()
        //{

        //    Random random = new Random();


        //    Array values = Enum.GetValues(typeof(CarType));
        //    CarType randomCar = (CarType)values.GetValue(random.Next(values.Length));
        //    Console.WriteLine("LOSOWY SAMOCHOD: " + randomCar);

        //    Array values2 = Enum.GetValues(typeof(EngineType));
        //    EngineType randomEngine = (EngineType)values2.GetValue(random.Next(values2.Length));
        //    Console.WriteLine("LOSOWY TYP SILNIKA: " + randomEngine);

        //}

    }
    
}
