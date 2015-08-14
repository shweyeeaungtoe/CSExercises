using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Double precision number");
           // String temp;
          //  temp = Console.ReadLine();

            double dnumber;
            dnumber = Convert.ToDouble(Console.ReadLine());

            double sqrtnumber = Math.Sqrt(dnumber);
            System.Console.WriteLine("Square root of the number\t" + sqrtnumber);
        }
    }
}
