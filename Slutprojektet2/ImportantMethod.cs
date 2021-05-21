using System;
using System.Collections.Generic;

namespace Slutprojektet2
{
    public class ImportantMethod
    {
        // En integer som används för att ge ett index till en Dictionary
        // (mer för att fylla ut Dictionaryt då den kräver 2 variabler)
        private int indexInt = 0;

        // Generiska klasser som är en del av huvudkoden
        // är relaterade till programmets logik
        private List<string> words = new List<string>();
        private Queue<string> wordQueue = new Queue<string>();
        private Dictionary<int, string> wordDict = new Dictionary<int, string>();

        // Metod för att skriva ut hello samt generera ett namn som skrivs ut
        public void Logic()
        {
            Greeting hello = new Greeting();

            HelloMethod(hello);

            hello.PrintName();
        }

        // Metod som hämtar in instansen hello och lägger till den i wordDict
        // tillsammans med indexInt.
        // Gör för att kunna skriva ut en string-properties från klassen Greeting 
        public void HelloMethod(Greeting hello)
        {
            hello.Text = "Hello ";

            wordQueue.Enqueue(hello.Text);

            words.Add(wordQueue.Dequeue());

            wordDict.Add(indexInt, words[0]);

            // Skriver ut alla Keys i wordDict-Dictionaryt
            // så att användaren kan se alla platser i den
            foreach (int key in wordDict.Keys)
            {
                System.Console.Write(wordDict[key]);
            }
        }

        // Metod som hanterar funktionerna relaterade till Car-klassen
        // Instancerar samt kör dess metoder
        // Använder sig av polymorfism i slaget av virtual och override samt forced
        public void CarMethod()
        {
            PrintCarBrands();

            System.Console.WriteLine("\nEnter the corresponding index to the desired brand: \n(entering the name of the brand will not work)");

            // En int som användaren specificerar, importeras sedan till TrackCar som en parameter till dess konstruktor
            int toImport = CheckPlayerInput();

            Console.Clear();

            Car trackCar = new TrackCar(toImport);

            
            ((TrackCar)trackCar).Drive();

            trackCar.PrintFuel();


            ((TrackCar)trackCar).AskForRefuel();

            
            trackCar.CarMethod();
        }

        // Konverterar input som ges av CheckPlayerInput-metoden till en int
        // Detta används för att säkerställa att användaren faktiskt skriver in en int, istället för en string
        // Returnerar den konverterade stringen
        public static int StringToInt(string playerInput)
        {
            int result = 0;
            bool success = int.TryParse(playerInput, out result);

            while (success != true)
            {
                System.Console.WriteLine("Please enter a number. Try again.");
                playerInput = Console.ReadLine().Trim();
                success = int.TryParse(playerInput, out result);
            }

            return result;
        }

        // Hämtar in användardata och kallar på StringToInt-metoden för att säkerställa att det är en int, instället för en string
        private int CheckPlayerInput()
        {
            string playerInput = Console.ReadLine().Trim();
            int intedString = StringToInt(playerInput);

            // Ser till att man väljer en plats i listan som existerar
            // Dictionaryt används bara för att presenterar användaren om alternativen som finns
            // inte för faktisk logik, då det är (i min åsikt) mer effektivt att istället enbart använda listan
            while (intedString <= 0 || intedString > TrackCar.carBrands.Count)
            {
                System.Console.WriteLine("The chosen brand does not exist.\nPlease try again.");

                playerInput = Console.ReadLine().Trim();
                intedString = StringToInt(playerInput);
            }

            return intedString;
        }

        public static int CheckPlayerInput2()
        {
            string playerInput = Console.ReadLine().Trim();
            int intedString = ImportantMethod.StringToInt(playerInput);

            // Ser till att man väljer en plats i listan som existerar
            // Dictionaryt används bara för att presenterar användaren om alternativen som finns
            // inte för faktisk logik, då det är (i min åsikt) mer effektivt att istället enbart använda listan
            while (intedString != 1 && intedString != 2)
            {
                System.Console.WriteLine("The chosen option does not exist.\nPlease try again.");

                playerInput = Console.ReadLine().Trim();
                intedString = StringToInt(playerInput);
            }

            return intedString;
        }

        // Skriver ut alla bilmärken så att användaren kan gå vidare i programmet
        private void PrintCarBrands()
        {
            System.Console.WriteLine("\n\nWhich car brand do you want to select?\n");
            System.Console.WriteLine("These are the available brands:");

            // Lägger till allt som finns i listan till dictionary
            for (int i = 0; i < TrackCar.carBrands.Count; i++)
            {
                // Index i listor börjar på 0, men vill att det visuella indexet ska börja på 1
                // För att lösa detta så ökar indexet med 1 för varje steg bland alla index
                // Genom denna lösning börjar Dictionaryts index 0 att lista en 1:a
                TrackCar.carBrandsDict.Add(i + 1, TrackCar.carBrands[i]);
            }

            // Skriver ut alla bilmärken som finns i Dictionaryt samt dess index (börjar på 1 istället för 0, se ovan)
            foreach (int key in TrackCar.carBrandsDict.Keys)
            {
                System.Console.WriteLine(key + ": | " + TrackCar.carBrandsDict[key]);
            }
        }
    }
}
