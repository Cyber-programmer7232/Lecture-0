﻿using System;
namespace Csharp
{
    class DeclaringConstantsApplication
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159; 
            Console.WriteLine("Enter Radius: "); r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}
