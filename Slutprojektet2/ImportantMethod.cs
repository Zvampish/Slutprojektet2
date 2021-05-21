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
            Car trackCar = new TrackCar();

            ((TrackCar)trackCar).Drive();
            trackCar.CarMethod();

            trackCar.PrintFuel();
        }
    }
}
