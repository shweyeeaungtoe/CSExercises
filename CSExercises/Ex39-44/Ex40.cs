using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex40
    {
       /* public static void Main(string[] args)
        {
            
        }

        public static double SQT(int y)
        {
            return 0;
        }*/
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:\t");
            double n = Convert.ToDouble(Console.ReadLine());
            double number = Factorial(n);
            Console.WriteLine(number);
        }
        static double Factorial(double n)
        {
            double i = 0;
            double num = 1;
            while (n != 0)
            {

                num = num * (n - i);
                i++;
            }
            return num;
        }
    }
}
