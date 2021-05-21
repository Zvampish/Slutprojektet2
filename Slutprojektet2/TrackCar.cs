using System;

namespace Slutprojektet2
{
    public class TrackCar : Car
    {
        // Konstruktor som sätter värden för bilen,
        // dessa värden är gemensamma då de befinner sig i Car-klassen
        public TrackCar()
        {
            FuelConsumtion *= 2;

            Brand = "Ferrari";

            FuelAmmount = 250;
        }

        // Metod som hanterar all logik relaterad till när fordonet körs
        public void Drive()
        {
            // Förbrukar bränsle som beror på vilken sorts bil
            // (för tillfället finns bara en bil, men går att bygga vidare senare)
            ConsumeFuel();
        }

        public override void CarMethod()
        {
            System.Console.WriteLine("test2");
            // base.CarMethod();
        }
    }
}
