using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {

            // 23 (a)
            Console.WriteLine("\n*****************23(a)***************\n\n\n");
            Random ran_number = new Random();

            int count = 0;
            Boolean equal = false;

            int random_number = 0, user_number = 0;

            random_number = ran_number.Next(0, 9);
            
            while (!equal)
            {
                Console.WriteLine("Enter a number:\t");
                user_number = Convert.ToInt32(Console.ReadLine());
                if (random_number == user_number)
                {
                    count++;
                    Console.WriteLine("\nCongratulate You!!!!");
                    Console.WriteLine("Your attempt times is\t"+count);
                    equal = true;
                }
                else
                {
                    Console.WriteLine("Write again!");
                    count++;
                }

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

           //   23(b)
            Console.WriteLine("\n\n\n\n****************23(b)********************");
            Random ran_number1 = new Random();

            int count1 = 0;
            Boolean equal1 = false;

            int random_number1 = 0, user_number1 = 0;

            random_number1 = ran_number1.Next(0, 9);

            while (!equal1)
            {
                Console.WriteLine("\n\n Enter a number:\t");
                user_number1 = Convert.ToInt32(Console.ReadLine());
                if (random_number1 == user_number1)
                {
                    count1++;
                    if (count1 == 1 || count1 == 2)
                    {
                        Console.WriteLine("\nYou are a Wizard!!!!");
                        Console.WriteLine("Your attempt times is\t" + count1);
                        equal1 = true;
                    }
                    else if (count1 == 3)
                    {
                        Console.WriteLine("\nYou are a good guess!!!!");
                        Console.WriteLine("Your attempt times is\t" + count1);
                        equal1 = true;
                    }
                    else if (count1 > 3)
                    {
                        Console.WriteLine("\nYou are a lousy!!!!");
                        equal1 = true;
                        Console.WriteLine("Your attempt times is\t" + count1);
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                    count1++;
                }

            }
        }
    }
}
