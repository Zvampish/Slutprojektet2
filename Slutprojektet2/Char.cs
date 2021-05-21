using System;
using System.Linq;

namespace Slutprojektet2
{
    public class Char
    {
        // Genererar ett random string genom att slumpa en följd av tecken från variabeln chars
        // Längden på den slumpade stringen sätts som parameter för metoden med inten length
        public string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[Program.generator.Next(s.Length)]).ToArray());
        }
    }
}
