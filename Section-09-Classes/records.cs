using System;

public class MyContacts
{
        static public void Main()
    {
       
        Person friend = new Person("Josh Hortt","Rua D", "911815877",180);
        // Adding a second fiend
        // 50. Challenge 1- filling the rest of friend2 parameters
        Person friend2 = new Person("Ana Rebelo","Rua A","912580048",165);
        // 51. Challenge 2 - adding 3 more friends
        Person friend3 = new Person("Sofia Rebelo","Rua B","912580049",165);
        Person friend4 = new Person("Alexandre Rebelo","Rua C","912580050",165);
        Person friend5 = new Person("Bruno Rebelo","Rua E","912580047",165);
            Console.Clear();
            friend.PrintDetails();
            // Adding a second friend
            friend2.PrintDetails();
            //51. Challenge 2 Adding 3 more friends
            friend3.PrintDetails();
            friend4.PrintDetails();
            friend5.PrintDetails();
    }
}