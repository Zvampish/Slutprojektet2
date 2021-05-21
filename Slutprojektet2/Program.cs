using System;

namespace Slutprojektet2
{
    class Program
    {
        public static Random generator = new Random();

        static void Main(string[] args)
        {
            ImportantMethod importantMethod = new ImportantMethod();

            // importantMethod.Logic();

            importantMethod.CarMethod();

            Console.ReadLine();
        }
    }
}
