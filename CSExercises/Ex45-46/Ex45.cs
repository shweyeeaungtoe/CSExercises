using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
       /* public static void Main(string[] args)
        {
            Console.Write("Enter a number:\t");
            int Input = Convert.ToInt32(Console.ReadLine());

            string Output = Input.ToString("X");
            Console.WriteLine("\nHexadecimal value of user input " + Input + "\tis\t" + Output); 

            string hexa_equal=Hex(Input);
            if (hexa_equal != null)
                Console.WriteLine("\n\nHexadecimal of a Input is equals one Hexadecimal from 1 to 100");
            else
                Console.WriteLine("\n\nHexadecimal of a Input is Not equal one Hexadecimal from 1 to 100");

        }

        public static string Hex(int i)
        {
            string[] Output=new string[100];

            string Output1 = i.ToString("X");

            int count = 0;
            Console.WriteLine("\n\nHexadecimal Value from 1 to 100 is");
            for (int j = 0; j < 100; j++)
            {
                Output[j] = (j+1).ToString("X");
                Console.Write(Output[j]+"\t");
              }

            for (int j = 0; j < 100; j++)
            {
                string out_put = Output[j];
                if (out_put.Equals(Output1))
                {
                    count++;
                    break;
                }
                else
                    count = 0;
            }

            if (count > 0)
                return Output1;
            else
                return null;
                
        }*/
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount:\t");
            double amount = Convert.ToDouble(Console.ReadLine());

           double floor_amount=Math.Floor(amount);
          // Console.WriteLine(Math.Round(floor_amount,2)); //1.99 => 1

           double floor_amount1 = floor_amount * 100;
           Console.WriteLine("\n"+floor_amount1+"c"); 

           double amount1 = Math.Round(amount - floor_amount,2);
          // Console.WriteLine(amount1);  // 1.99 =>0.99

           double amount2 = amount1 * 100;
         //  Console.WriteLine(amount2);



           if (amount2 >= 50)
           {
               amount2 = amount2 - 50;
               Console.WriteLine(50 + "c");

           }

           while ((amount2 >= 20 && amount2 < 50) || (amount2 <= 20 && amount2 > 10))
           {
               amount2 = amount2 - 20;
               Console.WriteLine(20 + "c");
           }
           if ((amount2 <= 10 && amount2 > 5)||(amount2 >= 10 && amount2 < 20))
           {
               amount2 = amount2 - 10;
               Console.WriteLine(10 + "c");
           }


           if (amount2 <= 5 && amount2 > 0)
           {
             //  amount2 = amount2 - 5;
               Console.WriteLine(5 + "c");
           }

        }
    }
}
