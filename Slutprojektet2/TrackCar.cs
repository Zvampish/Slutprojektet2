using System;
using System.Collections.Generic;

namespace Slutprojektet2
{
    public class TrackCar : Car
    {
        public static List<string> carBrands = new List<string>() {"Ferrari", "McLaren", "Mercedez Benz", "Tesla"};
        public static Dictionary<int, string> carBrandsDict = new Dictionary<int, string>();
        // Konstruktor som sätter värden för bilen,
        // dessa värden är gemensamma då de befinner sig i Car-klassen
        // Har en parameter som är till för att välja bilmärke
        // parametern sätts i ImportantMethod
        public TrackCar(int input)
        {
            FuelConsumtion *= 2;

            // Indexar med en mindre än användarinput eftersom att användaren ska välja ett tal som börjar på 1
            // men eftersom att listor och arrayer indexerar från 0 uppstår problemet att det lätt hänt blir "out of range"
            // vilket syftar på att man försöker komma åt något som inte existerar
            // dessutom så anropar man information som ligger på en högre i index
            Brand = carBrands[input-1];

            FuelAmount = 250;
            FuelAmountFull = FuelAmount;
        }

        // Metod som hanterar all logik relaterad till när fordonet körs
        public void Drive()
        {
            // Förbrukar bränsle som beror på vilken sorts bil
            // (för tillfället finns bara en bil, men går att bygga vidare senare)
            System.Console.WriteLine("The " + Brand + " drives a lap around a circuit and consumes " + FuelConsumtion + " gallons of fuel.");
            System.Console.Write("Amount of fuel left: ");
            ConsumeFuel();
        }

        public void AskForRefuel()
        {
            System.Console.WriteLine("Do you want to refuel the " + Brand + "?");
            System.Console.WriteLine("1: Yes   |   2: No");
            System.Console.WriteLine("\nEnter the corresponding number to make your selection");

            int temp = ImportantMethod.CheckPlayerInput2();

            Console.Clear();
            if (temp == 1)
            {
                Refuel();
            }

            else
            {
                System.Console.WriteLine("The car did not refuel");
            }
        }
        // Testar om polymorfismen funkar
        public override void CarMethod()
        {
            System.Console.WriteLine("Press ENTER to continue to see the polymorpism-test results:");
            Console.ReadLine();
            Console.Clear();

            System.Console.WriteLine("If the Polmorphism is working it will say 'test2' below this message.");

            System.Console.WriteLine("test2");
            // base.CarMethod();
        }
    }
}
