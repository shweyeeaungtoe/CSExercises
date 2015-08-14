using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please input the value of x: ");
           // String temp;
           // temp = Console.ReadLine();

            double x;
            x = Convert.ToDouble(Console.ReadLine());

            double y = (2 * Math.Pow(x, 2)) - 4 * x + 3;
            System.Console.WriteLine("Value of y\t" + y);
        }
    }
}
