using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Hello Student! \n Please Enter your marks:\t");
         
            int mark = Convert.ToInt32(Console.ReadLine());



            if (mark>=80 && mark<=100)
            {

                System.Console.WriteLine("Your scored:\t" + mark + "\tmarks" + "\twhich is A grade");
              
            }
            if (mark >= 60 && mark <= 79)
            {

                System.Console.WriteLine("Your scored:\t" + mark + "\tmarks" + "\twhich is B grade");

            }
            if (mark >= 40 && mark <= 59)
            {

                System.Console.WriteLine("Your scored:\t" + mark + "\tmarks" + "\twhich is C grade");

            }
            if (mark >= 0 && mark < 40)
            {

                System.Console.WriteLine("Your scored:\t" + mark + "\tmarks" + "\twhich is F grade");

            }
            if (mark > 100 || mark < 0)
            {

                System.Console.WriteLine("\nYour scored Can not be specified \n **********Error************");

            }


        }
    }
}