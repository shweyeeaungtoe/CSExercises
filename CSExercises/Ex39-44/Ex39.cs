using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:\t");
            double n = Convert.ToDouble(Console.ReadLine());
            double number = Factorial(n);
            Console.WriteLine("Factorial of\t" + n + ":\t" + number);
        }
        static double Factorial(double n)
        {
            double i = 0;
            double num = 1;
            double num1 = 0;
            num1 = n;
            while (n != 0)
            {

                num = num * (num1 - i);
                i++;
                n--;

            }
            return num;
        }
    }
}
