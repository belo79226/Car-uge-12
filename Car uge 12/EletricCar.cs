using System;
using System.Collections.Generic;
using System.Text;

namespace Car_uge_12
{
    public class EletricCar : Car
    {
        public double BatteryCapacity { get; private set; }
        public double BatteryLevel { get; private set; }
        public double KmPerKwh { get; private set; }

        public EletricCar(string brand, string model, int year,
                           double batteryCapacity, double kmPerKwh) : base(brand, model, year)
        {
            BatteryCapacity = batteryCapacity;
            KmPerKwh = kmPerKwh;
            BatteryLevel = batteryCapacity;
        }

        public override void UpdateEnergyLevel(double km)
        {
            BatteryLevel -= km / KmPerKwh;
            if (BatteryLevel < 0) BatteryLevel = 0;
        }

        public void Charge(double kwh)
        {
            BatteryLevel = Math.Min(BatteryLevel + kwh, BatteryCapacity);
        }
    }

}
