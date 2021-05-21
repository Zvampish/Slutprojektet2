using System;
using System.Collections.Generic;

namespace Slutprojektet2
{
    public class ImportantMethod
    {
        private int indexInt = 0;

        private List<string> words = new List<string>();
        private Queue<string> wordQueue = new Queue<string>();
        private Dictionary<int, string> wordDict = new Dictionary<int, string>();

        public void Logic()
        {
            Greeting hello = new Greeting();

            HelloMethod(hello);

            hello.PrintName();
        }

        public void HelloMethod(Greeting hello)
        {
            hello.Text = "Hello ";

            wordQueue.Enqueue(hello.Text);

            words.Add(wordQueue.Dequeue());

            wordDict.Add(indexInt, words[0]);

            foreach (int key in wordDict.Keys)
            {
                System.Console.Write(wordDict[key]);
            }
        }

        public void CarMethod()
        {
            Car trackCar = new TrackCar();

            ((TrackCar)trackCar).Drive();

            trackCar.PrintFuel();
        }
    }
}
