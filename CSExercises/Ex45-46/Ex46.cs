using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] rnd_arr = new int[50];
            int[] count_occurence = new int[10];
           
            Random rnd = new Random();
            int rnd_number = 0;
            int count = 1;



            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }


            Console.Write("Ramdom Number is\n");
            for (int i = 0; i < 50; i++)
            {
                rnd_number = rnd.Next(0, 9);
                rnd_arr[i] = rnd_number;

                Console.Write(rnd_arr[i] + "\t");


            }

            for (int i = 0; i < rnd_arr.Length; i++)
            {
                count = 1;

                for (int j = i+1; j < rnd_arr.Length; j++)
                 {
                       if (rnd_arr[i]==rnd_arr[j] && rnd_arr[i]!=11)
                        {                       
                       
                           count++;
                           rnd_arr[j] = 11;
                              
                        }
                 }

                for (int a = 0; a < 10; a++)
                {
                    if (count>0 && rnd_arr[i]==a)
                    {
                       
                        count_occurence[a] = count;
                    }
                }
               
            }

            Console.WriteLine("Numbers\t\t\t\tNumber of occurrences");
            Console.WriteLine("-------\t\t\t\t---------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i] + "\t\t\t\t" + count_occurence[i]);
            }


        }
    }
}
