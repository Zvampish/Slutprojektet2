using System;

namespace Slutprojektet2
{
    public class Car
    {
        private string brand = "";
        private int fuelConsumtion = 100;
        private int fuelAmmount = 0;

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

        public int ConsumeFuel()
        {
            FuelAmmount -= FuelConsumtion;

            return FuelConsumtion;
        }

        public void PrintFuel()
        {
            System.Console.WriteLine(FuelAmmount);
        }
    }
}
