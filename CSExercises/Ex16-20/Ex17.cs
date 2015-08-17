using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your Name:\t");
            String name = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender F or M:\t");
            String gender = Console.ReadLine();
            System.Console.WriteLine("Enter your Age:\t");

             int age = Convert.ToInt32(Console.ReadLine());
           


            if (gender.Equals("M"))
            {
                if (age >= 40)
                {
                    System.Console.WriteLine("Good Morning Uncle" + name);
                }
                if (age < 40)
                {
                    System.Console.WriteLine("Good Morning Mr." + name);
                }
            }
            else if (gender.Equals("F"))
            {
                if (age >= 40)
                {
                    System.Console.WriteLine("Good Morning Anty" + name);
                }
                if (age < 40)
                {
                    System.Console.WriteLine("Good Morning Ms." + name);
                }
            }
            else
                System.Console.WriteLine("Your gender can't be specified \n Please enter F or M");


        }
    }
}