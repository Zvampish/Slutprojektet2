using System;

namespace Slutprojektet2
{
    public class Car
    {
        private string brand;
        private int fuelConsumtion;

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

    }
}
