using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            int num1 = 0, number = 0;
            for (number = 1; number <= 1000; number++)
            {
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    num1+=i;

                } //end of inner for

                 
                 if (num1 == number)
                 Console.WriteLine(number + " is a perfect number:");

                 num1 = 0;
             
            }//end of outer
           
        }
    }
}
