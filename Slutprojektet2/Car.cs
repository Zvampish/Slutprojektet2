using System;

namespace Slutprojektet2
{
    public class Car
    {
        // Variabler som alla Car:s har (det finns för tillfället bara en sorts Car)
        // Dessa värden är place-holder värden som ska defineras om hos den ärvande klassen
        private string brand = "";
        private int fuelConsumtion = 100;
        private int fuelAmount = 0;
        private int fuelAmountFull = 0;

        // Tillhörande properties till de privata variablerna
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

        protected int FuelAmount
        {
            get
            {
                return fuelAmount;
            }

            set
            {
                fuelAmount = value;

                if (fuelAmount < 0)
                {
                    fuelAmount = 0;
                }
            }
        }

        protected int FuelAmountFull
        {
            get
            {
                return fuelAmountFull;
            }

            set
            {
                fuelAmountFull = value;

                if (fuelAmountFull < 0)
                {
                    fuelAmountFull = 0;
                }
            }
        }

        // Förbrukar bränsle genom att förbruka samma mängd som den ärvande Car-klassen har i bränsleförbrukning
        public int ConsumeFuel()
        {
            FuelAmount -= FuelConsumtion;

            return FuelConsumtion;
        }

        // Skriver ut bränslet som finns i tanken
        // Så att användaren vet hur mycket som finns kvar
        public void PrintFuel()
        {
            System.Console.WriteLine(FuelAmount + " gallons\n");
        }

        // En metod som är gjord för att bli överskriven av den ärvande klassen
        // Den testar att Polimorfin fungerar, därav texten "test"
        public virtual void CarMethod()
        {
            System.Console.WriteLine("test");
        }
        
        // Metod som hanterar tankning av bilen
        // UTÖKNING: Slumpning av mängd bränsle som tankas och om man vill tanka igen...
        public void Refuel()
        {
            //Tankar bilen
            FuelAmount += FuelConsumtion;

            // Informerar användaren om de som tankade bilen tankade för mycket
            if (FuelAmount > FuelAmountFull)
            {
                System.Console.WriteLine("The refuelsers did not do a good job, the fueltank is overflown");
                
                // Kan göras i propertyn, men det behövs göras i if-statementet för att kunna säga om tanken blev överfull eller ej
                // Detta kan även göras i propertyn, men det passar bra med en metod istället för att ha all kod i propertyn (mer uppdelad kod)
                FuelAmount = FuelAmountFull;
            }

            else
            {
                System.Console.WriteLine("The refuelsers did a good job, the fueltank is not overflown");
            }

            // Informerar användaren om man kan tanka bilen ytterliggare eller om den är full.
            if (FuelAmount >= FuelAmountFull)
            {
                System.Console.WriteLine("The tank is full, no more gas can be fueled");
            }

            else
            {
                System.Console.WriteLine("There is still some room in the tank for more fuel");
            }

            // Skriver ut den nya mängden bränsle som finns i tanken
            System.Console.WriteLine("The car has been refuled and has now " + FuelAmount + " gallons of fuel left\n\n");
        }
    }
}
