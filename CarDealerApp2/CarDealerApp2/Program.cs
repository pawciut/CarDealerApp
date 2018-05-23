using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerApp2
{
    class Program
    {
        static Random random = new Random();
        static List<Car> ListaSamochodow = new List<Car>();
        public static CarType GetRandomCarType()
        {
            Array carRandom = Enum.GetValues(typeof(CarType));
            CarType randomCar = (CarType)carRandom.GetValue(random.Next(carRandom.Length));        
            return randomCar;  
        }
        public static EngineType GetRandomEngine()
        {
            Array engineTypeRandom = Enum.GetValues(typeof(EngineType));
            EngineType randomEngine = (EngineType)engineTypeRandom.GetValue(random.Next(engineTypeRandom.Length));
            return randomEngine;
        }
        public static int GetRandomYear()
        {
            int year = random.Next(1995, 2018);
            return year;
        }
        static void Main(string[] args)
        {
            GenerateCars();    
            Console.ReadKey();
        }
        public static void ShowConstructorAction()
        {
            Car Car1 = new Car();
            Car Car2 = new Car(CarType.BMW);
            Car Car3 = new Car(CarType.Fiat, 2008, EngineType.Diezel, 4000);
        }
        public static decimal MnoznikCarType(CarType carType)                       
        {
            decimal mnoznikCarType;
            switch (carType)                                                      
            {
                case CarType.BMW:
                    mnoznikCarType = 3;
                    break;
                case CarType.Fiat:
                    mnoznikCarType = 0.5m;
                   break;
                case CarType.Ford:
                    mnoznikCarType = 1.2m;
                   break;
                case CarType.Opel:
                    mnoznikCarType = 0.8m;
                    break;
                default:
                    mnoznikCarType = 0;
                    break;
            }
            return mnoznikCarType;
        }
        public static decimal MnoznikEngineType(EngineType engineType)              
        {   
            decimal mnoznikEngineType;
            switch (engineType)                                                     
            {
                case EngineType.Benzyna:
                    mnoznikEngineType = 1.2m;
                    break;
                case EngineType.Diezel:
                    mnoznikEngineType = 1;
                    break;
                case EngineType.Inny:
                    mnoznikEngineType = 0.9m;
                    break;

                default:
                    mnoznikEngineType = 0;                                            
                    break;
            }
            return mnoznikEngineType;                                                 
        }                                                                            
        public static decimal MnoznikYear(int rocznik)
        {
            return (rocznik - 1994) * 1500;
        }
        public static decimal CreateCena(CarType carType, EngineType engineType, int rocznik)                           
        {
            decimal cena;
            cena = MnoznikCarType(carType) * MnoznikEngineType(engineType) * MnoznikYear(rocznik);
            return cena;
        }
        public static Car GenerateRandomCar()
        {
            Car auto = new Car();
            auto.Marka = GetRandomCarType();                   
            auto.TypSilnika = GetRandomEngine();                
            auto.Rocznik = GetRandomYear();                     
            auto.Cena = CreateCena(GetRandomCarType(), GetRandomEngine(), GetRandomYear());
            return auto;
        }
        public static Car[] GenerateCars()
        {
            Car[] arr = new Car[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GenerateRandomCar();
                arr[i].Wypisz();
            }
            return arr;
        }
    }
}

//auto.Wypisz();

//Console.WriteLine(auto.Marka);
//Console.WriteLine(auto.Rocznik);
//Console.WriteLine(auto.TypSilnika);
//Console.WriteLine(auto.Cena);
//ListaSamochodow.Add(Car1);
//ListaSamochodow.Add(Car2);
//ListaSamochodow.Add(Car3);

//Car1.Wypisz();
//Car2.Wypisz();
//Car3.Wypisz();

//ListaSamochodow.Add(new Car(CarType.Fiat, 2005, EngineType.Benzyna, 4000));
//ListaSamochodow.Add(new Car(CarType.BMW, 2008, EngineType.Diezel, 5000));

//ShowConstructorAction();


//foreach (Car xCar in ListaSamochodow)
//{
//    xCar.Wypisz();
//}
//Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


//Random random = new Random();
//int[] Rok;
//Rok = new int[3];
//Rok[0] = 2001;
//Rok[1] = 2008;
//Rok[2] = 2010;
//int year = random.Next(Rok.Length);

//return year;

//public static void TEST()
//{
//    string carModel;
//    string carManufacturer = "unknown";

//    Console.Write("Wpisz Model: ");

//    carModel = Console.ReadLine();

//    switch (carModel)
//    {
//        case "Astra":
//        case "Corsa":
//        case "Insignia":
//            carManufacturer = "Opel";
//            goto default;
//        case "Ceed":
//            carManufacturer = "Kia";
//            goto default;
//        case "Punto":
//            carManufacturer = "Fiat";
//            goto default;
//        default:
//            Console.WriteLine(carModel + " jest marki " + carManufacturer);
//            break;
//    }
//}


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