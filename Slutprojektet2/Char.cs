using System;
using System.Linq;

namespace Slutprojektet2
{
    public class Char
    {
        public string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Program.generator.Next(s.Length)]).ToArray());
        }
    }
}
