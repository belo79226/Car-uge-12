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

		private List<Trip> _trips = new List<Trip>();

		private Engine _engine;
	


	public Car(string brand, string model, int year, double kmPerLiter) //konstruktør 

		{

			Brand = brand;

			Model = model;

			Year = year;

			KmPerLiter = kmPerLiter;

			_engine = new Engine();

		}
	}
}
