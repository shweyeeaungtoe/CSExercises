using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
           int num1=0;
            Console.Write("--- Enter One number:\t---");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {


                if (number % i == 0)
                    num1+=i;

            }

            if (num1 != number)
                Console.WriteLine(number + " is not a perfect number:");
            if (num1 == number)
                Console.WriteLine(number + " is a perfect number:");

        }
    }
}
