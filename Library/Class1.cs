using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SolutionEquation
    {
        public static bool GetDiscriminant(double indexA, double indexB, double indexC, out double discriminant)
        {
            discriminant = indexB * indexB - 4 * indexA * indexC;
            if (discriminant >= 0) return true;
            return false;
        }
        public static void GetX(double indexB, double indexA, double discriminant,
                                   out double firstValue, out double secondValue)
        {
            firstValue = (-indexB - Math.Sqrt(discriminant)) / (2 * indexA);
            secondValue = (-indexB + Math.Sqrt(discriminant)) / (2 * indexA);
        }
    }
}
