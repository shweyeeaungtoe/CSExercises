using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
          
            Boolean equal = false;
            int number = 88, user_number = 0;
           

            while (!equal)
            {
                Console.WriteLine("Enter a number:\t");
                user_number = Convert.ToInt32(Console.ReadLine());
                if (number == user_number)
                {
                    Console.WriteLine("Lucky You!!!!");
                    equal = true;
                }
                else
                {
                    Console.WriteLine("\n\nWrite again!\n");
                }

            }



        }
    }
}
