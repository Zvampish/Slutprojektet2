using System;

namespace Slutprojektet2
{
    public class Word : Char
    {
        protected string randomString = "";

        public Word()
        {
            randomString = RandomString(Program.generator.Next(1, 11));
        }
    }
}
