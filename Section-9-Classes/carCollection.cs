using System;

class CarCollection
{
	static void Main()
	{
		CarDetails[] mycars = new CarDetails[3]; // 53. Challenge 3 - Just replace array value to [10]
		string make;
		string model;
		int year;
		string colour;
		string rego;

		for(int i = 0; i < mycars.Length; i++)
		{
			Console.WriteLine("Enter details for car {0}: ", i+1);
			Console.Write("Make: ");
			make = Console.ReadLine();
			Console.Write("Model: ");
			model = Console.ReadLine();
			Console.Write("Year: ");
			year = Convert.ToInt32(Console.ReadLine());
			Console.Write("Colour: ");
			colour = Console.ReadLine();
			Console.Write("Registration Number: ");
			rego = Console.ReadLine();

			mycars[i] = new CarDetails(make, model, year, colour, rego);
		}
		
		Console.Clear();
		for(int i = 0; i < mycars.Length; i++)
		{
			mycars[i].PrintDetails();
		}
	}
}

/*
Make: Honda
Model: civic
Year: 2000
Colour: red
Registration: 1212
=========================
Make: Toyota
Model: Carina
Year: 2003
Colour: blue
Registration: 1313
=========================
Make: Citroen
Model: Berlingo
Year: 1997
Colour: white
Registration: 1414
=========================
*/


// ******************************************************************************
/*Use the code from the previous lecture to create a program to read in the values
 of 10 cars before printing out the details for all.
Resources for this lecture
cardetails-solution.cs    SEE 53. Challenge 3 up in the code line 7*/