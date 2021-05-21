using System;
using System.Collections.Generic;

namespace Slutprojektet2
{
    public class ImportantMethod
    {
        private int indexInt = 0;

        List<string> words = new List<string>();
        Queue<string> wordQueue = new Queue<string>();
        Dictionary<int, string> wordDict = new Dictionary<int, string>();

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
    }
}
