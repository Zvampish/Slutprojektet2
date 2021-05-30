using System;

namespace Slutprojektet2
{
    public class LapsMaker
    {
        // Frågar användaren om en förändring av antalet laps
        // och ändrar därefter den statiska variablen som ligger i Car-klassen.
        public LapsMaker()
        {
            System.Console.WriteLine("Number of laps?");

            int.TryParse(Console.ReadLine(), out int converted);

            Car.numberOfLaps = converted;

            Console.Clear();

            System.Console.Write("Number of laps: ");
            Car.PrintLaps();
        }
    }
}
