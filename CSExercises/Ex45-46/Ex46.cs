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
            int k = 0;

            Random rnd = new Random();
            int rnd_number = 0;
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            for (int i = 0; i < 50; i++)
            {
                rnd_number = rnd.Next(0, 9);
                rnd_arr[i] = rnd_number;

                Console.Write(rnd_arr[i] + "\t");


            }

            for (int i = 0; i < rnd_arr.Length; i++)
            {
                count = 0;

                for (int j = rnd_arr.Length-1; j >=0; j--)
                 {
                       if (rnd_arr[i].Equals(rnd_arr[j]) && rnd_arr[i] != -1)
                        {                       
                          // Console.WriteLine(i+"\t"+count);
                            Console.WriteLine("equal");
                           rnd_arr[j] = -1;
                              
                        }
                 }
               

                if (count > 0)
                {
                    
                    if(k<10)
                    count_occurence[k] = count; 
                }
                
                k++;
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
