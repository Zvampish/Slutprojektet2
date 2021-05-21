using System;

namespace Slutprojektet2
{
    class Program
    {
        public static Random generator = new Random();

        static void Main(string[] args)
        {
            ImportantMethod importantMethod = new ImportantMethod();

            //Skriver ut "Hello" och namnet/id:n
            importantMethod.Logic();
            
            // All logik kopplad till bilar
            // Klassen gör mycket, dock struktuerad med flera metoder
            importantMethod.CarMethod();

            System.Console.WriteLine("\nThe program has come to an end. Goodbye!");
            System.Console.WriteLine("Press ENTER to exit the program");
            Console.ReadLine();
        }
    }
}
