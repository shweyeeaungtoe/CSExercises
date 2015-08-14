using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c;

            System.Console.Write("Please input the value of A: ");
            a = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Please input the value of B: ");
            b = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Please input the value of C: ");
            c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            System.Console.WriteLine("Area\t" + area);

        }
    }
}