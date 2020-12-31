using System;
public class Person  // THIS IS THE CLASS
{
    string name = "";
    string address = "";
    string phone = "";
    float height = 0;
    

    public Person(string n, string a, string p, float h) // THIS IS THE CONSTRUCTOR
    {
       // name = "Josh Hortt";
        name = n; // we are passing the name to a string variable called n'. Note that we can t name it name'.
        /*address = "Rua D";
        phone = "911815877";
        height = 180;*/
        address = a;
        phone = p;
        height = h;

    }
    
    public void PrintDetails()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("== Person details ==");
        Console.WriteLine("====================");
        Console.WriteLine("Name: " + name + "\n" +
                            "Address: " + address + "\n" +
                            "Phone: " + phone + "\n" +
                            "Height: " + + height + "\n");
         Console.WriteLine("====================");
    }
}