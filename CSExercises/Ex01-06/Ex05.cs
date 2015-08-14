using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Double number");
            String temp;
            temp = Console.ReadLine();

            double dnumber;
            dnumber = Convert.ToDouble(temp);

            double sqrtnumber = Math.Sqrt(dnumber);
            System.Console.WriteLine("Square root of the number\t" + sqrtnumber);
            System.Console.WriteLine("Rounded to 3 decimal places of the number\t{0:###.###}", sqrtnumber);
        }
    }
}
