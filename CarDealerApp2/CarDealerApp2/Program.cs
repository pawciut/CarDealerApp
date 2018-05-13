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



        public static void GetRandomCarType()
        {
            Random random = new Random();
            Array carRandom = Enum.GetValues(typeof(CarType));
            CarType randomCar = (CarType)carRandom.GetValue(random.Next(carRandom.Length));

            Console.WriteLine("LOSOWY SAMOCHOD: " + randomCar);

        }
        public static void GetRandomEngine()
        {
            Random random = new Random();
            Array engineTypeRandom = Enum.GetValues(typeof(EngineType));
            EngineType randomEngine = (EngineType)engineTypeRandom.GetValue(random.Next(engineTypeRandom.Length));

            Console.WriteLine("LOSOWY TYP SILNIKA: " + randomEngine);
        }
        public static void GetRandomYear()
        {
            Random random = new Random();
            int[] Rok;
            Rok = new int[3];
            Rok[0] = 2001;
            Rok[1] = 2008;
            Rok[2] = 2010;
            int Year = random.Next(Rok.Length);

            Console.WriteLine("LOSOWY ROK: " + Rok[Year]);
        }

        static void Main(string[] args)
        {
            ListaSamochodow.Add(new Car(CarType.Fiat, 2005, EngineType.Benzyna, 4000));
            ListaSamochodow.Add(new Car(CarType.BMW, 2008, EngineType.Diezel, 5000));

            ShowConstructorAction();


            foreach (Car xCar in ListaSamochodow)
            {
                xCar.Wypisz();
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            GenerateRandomCar();
            //GetRandomCarType();
            //GetRandomEngine();
            //GetRandomYear();
            //TEST();
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

        

        public static void MnoznikCarType()
        {
            CarType carType = new CarType();
            decimal mnoznikCarType;


            switch (carType)
            {
                case CarType.BMW:
                    mnoznikCarType = 3;
                    goto default;
                case CarType.Fiat:
                    mnoznikCarType = 0.5m;
                    goto default;
                case CarType.Ford:
                    mnoznikCarType = 1.2m;
                    goto default;
                case CarType.Opel:
                    mnoznikCarType = 0.8m;
                    goto default;

                default:
                    break;
            }

        }
        public static void MnoznikEngineType()
        {
            EngineType engineType = new EngineType();
            decimal mnoznikEngineType;

            switch (engineType)
            {
                case EngineType.Benzyna:
                    mnoznikEngineType = 1.2m;
                    goto default;
                case EngineType.Diezel:
                    mnoznikEngineType = 1;
                    goto default;
                case EngineType.Inny:
                    mnoznikEngineType = 0.9m;
                    goto default;

                default:
                    break;

            }
        }

        
        public static Car GenerateRandomCar()
        {
            Car Auto = new Car();
            GetRandomCarType();
            GetRandomEngine();
            GetRandomYear();

            cena = MnoznikCarType * MnoznikEngineType; // * mnożnik roku



            return Auto;
        }
    }
}


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