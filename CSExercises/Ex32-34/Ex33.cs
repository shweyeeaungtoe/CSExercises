using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int temp = 0;
            int[] num_arr = new Int32[20];
            num_arr[0] = 86;
            num_arr[1] = 35;
            num_arr[2] = 41;
            num_arr[3] = 49;
            num_arr[4] = 89;

            num_arr[5] = 51;
            num_arr[6] = 11;
            num_arr[7] = 71;
            num_arr[8] = 50;
            num_arr[9] = 75;

            num_arr[10] = 25;
            num_arr[11] = 58;
            num_arr[12] = 40;
            num_arr[13] = 14;
            num_arr[14] = 44;

            num_arr[15] = 3;
            num_arr[16] = 63;
            num_arr[17] = 81;
            num_arr[18] = 93;
            num_arr[19] = 79;

            for (int i = 0; i < num_arr.Length; i++)
            {
                for (int j = num_arr.Length - 1; j >= i; j--)
                {

                    if (num_arr[j] > num_arr[i])
                    {
                        temp = num_arr[j];
                        num_arr[j] = num_arr[i];
                        num_arr[i] = temp;
                    }
                    
                }
            }

            Console.WriteLine("Decending Order:\n");
            for (int i = 0; i < num_arr.Length; i++)
            {
                Console.WriteLine(num_arr[i]);

            }
        }
    }
}
