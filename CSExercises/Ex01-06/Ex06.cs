using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Integer number");
           // String temp;
          //  temp = Console.ReadLine();

            int intnumber;
            intnumber = Convert.ToInt32(Console.ReadLine());

            double dnumber = Math.Sqrt(intnumber);
            System.Console.WriteLine("Square root of the number\t" + dnumber);
        }
    }
}
