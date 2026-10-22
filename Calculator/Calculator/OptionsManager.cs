using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "ex - Exit",
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Divide",
            "sabs - Substract Abs",
            "dr - Divide Remainder",
            "min - Minimum",
             };

        public static void Add(double a, double b)
        {
            Console.WriteLine( $"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine( $"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine( $"{a} - {b} = {a - b}");
        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} : {b} = {a/b}");
        }

        public static void SubstractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a-b)}");
        }
        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine( $"{a} % {b} = {a % b}");
        }
		
	public static void Minimum(double a, double b)
    {
        double min = (a < b) ? a : b;
	    Console.WriteLine(min);
	}
    }
}
