using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Double precision number");
            String temp;
            temp = Console.ReadLine();

            double dnumber;
            dnumber = Convert.ToDouble(temp);

            double pownumber = Math.Pow(dnumber, 2);
            System.Console.WriteLine("Square of the number\t" + pownumber);
        }
    }
}
