
using System;

public class ForLoopAverage
{
    static public void Main()
    {

        int total = 0;
        Console.Clear();
        Console.WriteLine("Please enter values:");

        for (int i = 1; i <= 10; i++)
        
         {
            Console.WriteLine ("Enter a value: {0}", i);
            total = total + Convert.ToInt32(Console.ReadLine());
         }
            float avg = total/(float)10.0f;
            
            Console.WriteLine ("The Average is: {0}", avg);
    } 
}

/*
Please enter values:
Enter a value: 1
5
Enter a value: 2
2
Enter a value: 3
1
Enter a value: 4
12
Enter a value: 5
10
Enter a value: 6
5
Enter a value: 7
3
Enter a value: 8
2
Enter a value: 9
3
Enter a value: 10
2
The Average is: 4,5
*/

// Now if you wanted to read in a variable amount of values so let's sau you wanted to find the average
// mark of a class of students, and each time that class of students is a different size before the for loop
// we could ask the programm to ask the user to enter in how many values that tehy have.
/*

using System;

public class ForLoopAverage
{
    static public void Main()
    {

        int total = 0;
        float numberOfStudents;
        Console.Clear();
        Console.WriteLine("Please enter the number of students:");
        numberOfStudents = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please enter values:");

        for (int i = 1; i <=numberOfStudents; i++)
        
         {
            Console.WriteLine ("Enter a value: {0}", i);
            total = total + Convert.ToInt32(Console.ReadLine());
         }
            float avg = total/numberOfStudents;
            
            Console.WriteLine ("The Average Mark is: {0}", avg);
    } 
}

Please enter the number of students:
4
Please enter values:
Enter a value: 1
5
Enter a value: 2
19
Enter a value: 3
13
Enter a value: 4
11
The Average Mark is: 12
*/