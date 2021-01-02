
/*
The line foreach (string groceryItem in myGroceryList) can be read as "for each item in myGroceryList, 
name it groceryItem, then run the line of code between the curly braces.
" In this case, we're printing each item in myGroceryList to the console.
*/

using System;

public class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};

    Console.WriteLine("My grocery list:");

    foreach (string groceryItem in myGroceryList)
    {
      Console.WriteLine(groceryItem);
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
yogurt
*/