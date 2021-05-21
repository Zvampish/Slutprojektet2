using System;

namespace Slutprojektet2
{
    public class Car
    {
        // Variabler som alla Car:s har (det finns för tillfället bara en sorts Car)
        // Dessa värden är place-holder värden som ska defineras om hos den ärvande klassen
        private string brand = "";
        private int fuelConsumtion = 100;
        private int fuelAmmount = 0;

        // Tillhörande property till de privata variablerna
        protected string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        protected int FuelConsumtion
        {
            get
            {
                return fuelConsumtion;
            }

            set
            {
                fuelConsumtion = value;
            }
        }

        protected int FuelAmmount
        {
            get
            {
                return fuelAmmount;
            }

            set
            {
                fuelAmmount = value;

                if (fuelAmmount < 0)
                {
                    fuelAmmount = 0;
                }
            }
        }

        // Förbrukar bränsle genom att förbruka samma mängd som den ärvande Car-klassen har i bränsleförbrukning
        public int ConsumeFuel()
        {
            FuelAmmount -= FuelConsumtion;

            return FuelConsumtion;
        }

        // Skriver ut bränslet som finns i tanken
        // Så att användaren vet hur mycket som finns kvar
        public void PrintFuel()
        {
            System.Console.WriteLine(FuelAmmount);
        }

        // En metod som är gjord för att bli överskriven av den ärvande klassen
        // Den testar att Polimorfin fungerar, därav texten "test"
        public virtual void CarMethod()
        {
            System.Console.WriteLine("test");
        }
    }
}
