using System;
using System.Collections.Generic;
using System.Text;

namespace Car_uge_12
{
    public class FuelCar : Car, IInsurable, ISellable
    {
        public double TankCapacity { get;}
        public double FuelLevel { get; private set; }
        public double KmPerLiter { get; private set; }
        public string RegistrationNumber => LicensePlate;
        public double Price { get; set; }
        public FuelCar(string brand, string model, int year, double kmPerLiter, double tankCapacity, string licensePlate, double price) : base(brand, model, year, licensePlate)
        {
            TankCapacity = tankCapacity;
            FuelLevel = tankCapacity; // Starter med fuld tank
            KmPerLiter = kmPerLiter;
            Price = price;
        }

        public double GetInsuranceRate()
        { return 5.0; }
        public string GetSalesSummary()
        {
            return $"Salg af {Brand} {Model} ({Year}) - Pris: {Price} kr. | Tankkapacitet: {TankCapacity} L | Rækkevidde: {TankCapacity * KmPerLiter} km";
        }

        public override void UpdateEnergyLevel(double km)
        {
            double fuelUsed = km / KmPerLiter;
            FuelLevel -= fuelUsed;
            if (FuelLevel < 0)
            {
                FuelLevel = 0; // Undgå negativt brændstof
                Console.WriteLine("Advarsel: Brændstoffet er opbrugt!");
            }
        }

    public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fejl: Mængden af brændstof skal være positiv.");
                return;
            }
            FuelLevel += liters;
            if (FuelLevel > TankCapacity)
            {
                FuelLevel = TankCapacity; // Undgå overfyldning
                Console.WriteLine("Advarsel: Tankkapaciteten er overskredet! Brændstoffet er nu på maksimum.");
            }
        }
    }
}
