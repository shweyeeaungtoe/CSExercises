using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int remainder, num, addnum = 0;

            Console.WriteLine("Enter Number\t");

            num = int.Parse(Console.ReadLine());
            for (int j = num; j > 0; j = j / 10)
            {
                remainder = j % 10;
                addnum = addnum + remainder * remainder * remainder;

            }
            if (addnum == num)
            {
                Console.Write("Entered Number is an Armstrong Number");
            }
            else
                Console.Write("Entered Number is not an Armstrong Number");
            Console.ReadLine();
        }
    }
}