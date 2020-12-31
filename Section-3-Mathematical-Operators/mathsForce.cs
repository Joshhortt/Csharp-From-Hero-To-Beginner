using System;

public class MathsForce
{
    static public void Main()
        // F=ma
    {   float force;
        float mass = 3.0f;
        float acceleration = 10.5f;

        force = mass * acceleration;
      
        Console.WriteLine ("Total of Force is: {0}", force);
    }
}