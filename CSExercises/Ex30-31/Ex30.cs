using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int num = 0, num1 = 0, number = 0;
            for (number = 5; number <= 1000;number++ )
            {
                for (int i = 2; i < number; i++)
                {

                    if (number % i != 0)
                        num++;

                    else if (number % i == 0)
                        num1++;

                }//end of inner for

                if (num1 == 0 && num > 0)
                {
                   
                    Console.WriteLine(number + " is a prime number:");
                  
                }
                /*if (num1 > 0)
                    Console.WriteLine(number + " is not a prime number:");*/

                num1 = 0;
                num = 0;
            }//end of outer

            
        }
    }
}
