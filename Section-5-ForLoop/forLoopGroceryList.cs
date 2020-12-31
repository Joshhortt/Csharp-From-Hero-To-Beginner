using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice", "coffee" };

    Console.WriteLine("My grocery list:");
    for (int i = 0; i < myGroceryList.Length; i++)
    {
      Console.WriteLine(myGroceryList[i]);
    }
  }
}

/*
My grocery list:
eggs
milk
bread
bananas
cereal
rice
coffee

*/