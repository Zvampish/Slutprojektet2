using System;

namespace Slutprojektet2
{
    public class Greeting : Word
    {
        // Variabel för klassen, används i propertyn
        private string text = "";

        // En property som sätter och hämtar värdet på text
        // Används i ImportantMethod-klassen
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
            System.Console.WriteLine(RandomString2 + "!");
        }
    }
}
