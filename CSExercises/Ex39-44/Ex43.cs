using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {
            Console.Write("Please integer number to change hex\t");
            int number = Convert.ToInt32(Console.ReadLine());
            string answer = Hex(number);
            Console.WriteLine("HexaDecimal:\t" + answer);
        }
        public static string Hex(int i)
        {
            string answer = "";
            int remainder = i;
            if (i >= 16)
            {
                while (i / 16 > 0)
                {
                    answer += (i / 16).ToString();

                    remainder = i % 16;

                    i = i / 16;
                }
            }

            switch (remainder)
            {
                case 10:
                    answer += "A";
                    break;
                case 11:
                    answer += "B";
                    break;
                case 12:
                    answer += "C";
                    break;
                case 13:
                    answer += "D";
                    break;
                case 14:
                    answer += "E";
                    break;
                case 15:
                    answer += "F";
                    break;
                default:
                    answer += remainder.ToString();
                    break;
            }
            return answer;
        }












       /* public static void Main(string[] args)
        {
            Console.Write("Enter a number:\t");
            int Input = Convert.ToInt32(Console.ReadLine());


            string user_hexa = Hex(Input);


            Console.WriteLine("\nHexadecimal value of user input " + Input + "\tis\t" + user_hexa);




        }

        public static string Hex(int i)
        {
            string[] Output = new string[100];
            string Hexa_Output = i.ToString("X");

            Console.WriteLine("\n\nHexadecimal Value from 1 to 100 is");
            for (int j = 0; j < 100; j++)
            {
                string Hexa_Output1 = (j + 1).ToString("X");
                Output[j] = Hexa_Output1;
                Console.Write(Hexa_Output1 + "\t");
            }
            for (int j = 0; j < 100; j++)
            {
                string out_put = Output[j];
                if (out_put.Equals(Hexa_Output))
                {
                    Console.WriteLine("\n\nHexadecimal of user Input is equals Hexadecimal from 1 to 100");
                    break;
                }

            }


            return Hexa_Output;


        

        }*/
    }
}
