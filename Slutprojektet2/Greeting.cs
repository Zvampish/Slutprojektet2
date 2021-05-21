using System;

namespace Slutprojektet2
{
    public class Greeting : Word
    {
        private string text;

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public void PrintName()
        {
            System.Console.WriteLine(randomString + "!");
        }
    }
}
