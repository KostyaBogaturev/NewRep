﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QE
{
    class Program
    {
        static void Main(string[] args)
        {
            double indexA, indexB, indexC;
            Console.Write("Enter index A: ");
            indexA = double.Parse(Console.ReadLine());
            Console.Write("Enter index B: ");
            indexB = double.Parse(Console.ReadLine());
            Console.Write("Enter index C: ");
            indexC = double.Parse(Console.ReadLine());
            Console.WriteLine($"{indexA}x^2 + {indexB}x + {indexC} = 0");
            double discriminant = indexB * indexB - 4 * indexA * indexC;
            double firstValue, secondValue;
            firstValue = (-indexB - Math.Sqrt(discriminant)) / (2 * indexA);
            secondValue = (-indexB + Math.Sqrt(discriminant)) / (2 * indexA);
            Console.WriteLine($"x1= {firstValue} ,x2= {secondValue}");
            Console.Read();
        }
    }
}
