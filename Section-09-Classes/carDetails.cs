using System;

class Car
{
	string make;
	string model;
	int year;
	string colour;
	string rego;

	public Car(string m, string mod, int y, string c, string r)
	{
		make = m;
		model = mod;
		year = y;
		colour = c;
		rego = r;
	}

	public void PrintDetails()
	{
		Console.WriteLine("Make: " + make);
		Console.WriteLine("Model: " + model);
		Console.WriteLine("Year: " + year);
		Console.WriteLine("Colour: " + colour);
		Console.WriteLine("Registration: " + rego);
		Console.WriteLine("=========================");
	}

}