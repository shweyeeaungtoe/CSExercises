using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your Name:\t");
            String name = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender F or M:\t");
            String gender = Console.ReadLine();

          
            if (gender.Equals("M"))
            {
                System.Console.WriteLine("Good Morning Mr." + name);
            }
            else if(gender.Equals("F"))
            {
                System.Console.WriteLine("Good Morning Ms." + name);
            }
            else
                System.Console.WriteLine("Your gender can't be specified");


        }
    }
}