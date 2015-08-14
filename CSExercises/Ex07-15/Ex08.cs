using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Temperature in Centigrade scale");
            String temp;
            temp = Console.ReadLine();

            /*double C;
            C = Convert.ToDouble(temp);


            double F = 1.8 * C + 32;


            System.Console.WriteLine("Temperature in Farenheit\t" + F);*/

            double C;
            C = Convert.ToDouble(temp);


            double F = 1.8 * C + 32;
            int F_int = Convert.ToInt32(F);

            System.Console.WriteLine("Temperature in Farenheit\t" + F_int);

        }
    }
}
