using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace QE
{
    class Program
    {
        static void Main(string[] args)
        {
            double indexA, indexB, indexC;
            while (true)
            {
                Console.Write("Enter index A: ");
                Validation(out indexA);
                Console.Write("Enter index B: ");
                Validation(out indexB);
                Console.Write("Enter index C: ");
                Validation(out indexC);
                Console.WriteLine($"{indexA}x^2 + {indexB}x + {indexC} = 0");
                if (SolutionEquation.GetDiscriminant(indexA, indexB, indexC, out double discriminant))
                {
                    SolutionEquation.GetX(indexB, indexA, discriminant, out double firstValue, out double secondValue);
                    Console.WriteLine($"x1= {firstValue} ,x2= {secondValue}");
                }
                else
                {
                    Console.WriteLine($"Discriminant = {discriminant}<0");
                }
                Console.WriteLine("Enter '1' to close app");
                switch (Console.ReadLine())
                {
                    case "1":
                        return;
                    default:
                        Console.Clear();
                        break;
                }

            }
        }
         private static double Validation(out double index)
        {
            string strIndex = Console.ReadLine();
            while (!double.TryParse(strIndex, out index))
            {
                Console.WriteLine("Try again !");
                strIndex=Console.ReadLine();
            }
            return index;
        }
    }
}
