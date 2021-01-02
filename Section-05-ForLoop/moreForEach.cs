/*
Looping Through ints
We can loop through any type of an array. Let's add functionality to keep track of our grocery trip's cost:

We create a second array int[] groceryListPrices to store the prices of myGroceryList items.

We create a new int variable named total and set it to 0. It's important we do this outside the loop, 
otherwise it will reset to 0 at the beginning of each loop iteration.

Inside the loop, we update total to equal total + price. price represents one item in groceryListPrices 
as the for each loop goes through each item in the array.

This pattern where we add to a variable and re-save the new value to that variable is so common there's 
an operator just for that: +=. total = total + price;

*/

using System;

public class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};
    int[] groceryListPrices = { 3, 6, 4, 2, 4, 4};

    Console.WriteLine("My grocery list:");
    foreach (string groceryItem in myGroceryList)
    {
      Console.WriteLine(groceryItem);
    }

    int total = 0;
    foreach (int price in groceryListPrices)
    {
      total = total + price;
    }

    Console.WriteLine("Your total for this shopping trip will be $" + total);
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
Your total for this shopping trip will be $23
*/