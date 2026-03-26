using System;
using System.Collections.Generic;
using System.Text;

namespace Car_uge_12
{
    public class EletricCar : Car, IInsurable, ISellable
    {
        public double BatteryCapacity { get; private set; }
        public double BatteryLevel { get; private set; }
        public double KmPerKwh { get; private set; }

        public string RegistrationNumber => LicensePlate;
        public double Price { get; set; }

        public EletricCar(string brand, string model, int year,
                           double batteryCapacity, double kmPerKwh, string licensePlate, double price) : base(brand, model, year, licensePlate)
        {
            BatteryCapacity = batteryCapacity;
            KmPerKwh = kmPerKwh;
            BatteryLevel = batteryCapacity;
            Price = price;
        }
        public double GetInsuranceRate()
        { return 1.2; }
        public string GetSalesSummary()
        {
            return $"Salg af {Brand} {Model} ({Year}) - Pris: {Price} kr. | Batterikapacitet: {BatteryCapacity} kWh | Rækkevidde: {BatteryCapacity * KmPerKwh} km";
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
