using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Calculation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Deduction(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            return (double)a / b;
        }
    }
}
