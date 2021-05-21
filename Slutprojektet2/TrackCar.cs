using System;

namespace Slutprojektet2
{
    public class TrackCar : Car
    {
        public TrackCar()
        {
            FuelConsumtion *= 2;

            Brand = "Ferrari";

            FuelAmmount = 250;
        }

        public void Drive()
        {
            ConsumeFuel();
        }
    }
}
