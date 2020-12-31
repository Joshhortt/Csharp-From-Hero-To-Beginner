using System;

abstract class Animal // abstract class
{
	public abstract int LegCount();  // abstract class that has no parameters and doesn't return anything,
    // because it's abstract
}
class Mammal: Animal  // class Mammal that extends the class Animal (It´s going to inherit all that 
                     // is inside the abstract class Animal including the abstract class LegCount)
{
	public bool fur;
	public string name;
	public Mammal() { }  // the constructor

	public override int LegCount()
	{
		return 4;
	}

	public void Print()
	{
		Console.WriteLine("A {0} has {1} legs.", name, LegCount());
		if(fur)
		  Console.WriteLine("It has fur.");
		else
		  Console.WriteLine("It has no fur.");
	}
}
// Here below, I added two more Mammal classes
class Dolphin: Mammal  // add a mammal class called Dolphin
{
	public Dolphin(){ fur = false; name = "Dolphin";}
	public override int LegCount()
	{
		return 0;
	}
}

class Wombat: Mammal  // Another mammoth class called Wombat
{
	public Wombat() { fur = true; name = "Wombat";}
}

class CreateAnimals // here is the method
{
	static void Main()
	{
		Wombat w = new Wombat();
		w.Print();

		Dolphin d = new Dolphin();
		d.Print();
	}
}
/*
A Wombat has 4 legs.
It has fur.
A Dolphin has 0 legs.
It has no fur.
*/