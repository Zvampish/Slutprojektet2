using System;

namespace Slutprojektet2
{
    public class Word : Char
    {
        // En string som ska bli slumpad 
        private string randomString2 = "";

        // Property som hanterar koden relaterad till stringen randomString2
        // Inkapsling av variablen
        protected string RandomString2
        {
            get
            {
                return randomString2;
            }

            set
            {
                randomString2 = value;
            }
        }

        // Sätter ett slumpat värde/data på propertyn genom att köra RandomString-metoden
        // Längden på datan är också slumpad med en längd melan 1 och 10
        public Word()
        {
            RandomString2 = RandomString(Program.generator.Next(1, 11));
        }
    }
}
