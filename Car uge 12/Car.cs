using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace Car_uge_12
{
	public abstract class Car
	{
		public string Brand { get; private set; } //fields og {properties}

		public string Model { get; private set; }

		public int Year { get; private set; }

		public double KmPerLiter { get; private set; }

		public double Odometer { get; private set; }
		public bool IsEngineOn { get; private set; }

		private List<Trip> _trips = new List<Trip>();

        //private Engine _engine;


        //Konstruktør: initialiserer bilens egenskaber og starter med motoren slukket
        public Car(string brand, string model, int year, double kmPerLiter) //konstruktør 

		{

			Brand = brand;

			Model = model;

			Year = year;

			KmPerLiter = kmPerLiter;

			IsEngineOn = false;

			//_engine = new Engine();

		}


        // Abstrakt metode: underklassen definerer, hvordan energi opdateres 
        public abstract void UpdateEnergyLevel(double km);

        // Drive() er fælles — men kalder den abstrakte metode 
        public void Drive(Trip trip)
		{
			if (IsEngineOn)
			{
				Odometer += trip.Distance;
				UpdateEnergyLevel(trip.Distance); //Delegeres til underklassen
				_trips.Add(trip);
            }
            else
			{
				Console.WriteLine("Fejl: Motoren er ikke tændt. Start motoren før du kører.");
            }

        }

	}
}
