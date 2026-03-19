using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Car_uge_12
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; }
        public double BatteryLevel { get; private set; }
        public double KmPerKwh { get; set; }
    

    public ElectricCar(string brand, string model, int year, double kmPerKwh, double batteryCapacity)
        {
            BatteryCapacity = batteryCapacity;
            BatteryLevel = batteryCapacity;
            KmPerKwh = kmPerKwh;
        }

        public override void UpdateEnergyLevel(double km)
        {
            double kwhUsed = km / KmPerKwh
        }

    }



}
    