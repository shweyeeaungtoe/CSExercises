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
            int[] arr=new int[10];
            int[] rnd_arr = new int[50];
            Random rnd = new Random();
            int rnd_number=0;
            int count = 0;

            for (int i = 0; i < 50; i++)
            {
                rnd_number = rnd.Next(0,9);
                rnd_arr[i] = rnd_number;

                Console.Write(rnd_number+"\t");
              

            }

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (rnd_arr[i] == rnd_arr[j])
                        count++;
                
                }
                arr[i] = count;
                count = 0;
            }


        }
    }
}
