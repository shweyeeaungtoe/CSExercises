using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("36(a)-----> Please Enter one pharse:\t");
            String word = (Console.ReadLine());

            int number=word.Length;

            String[] panlin_str = new String [number];
            String[] input_str = new String[number];
            int count_equal = 0;
            int count_notequal = 0;
            int index = 0;
          //  Console.WriteLine("String Length:\t"+word.Length+"\n");
            for (int i = 0; i < word.Length; i++)
            {
                index += 1;
                
                panlin_str[i] = word.Substring(word.Length - index, 1);
                input_str[i] = word.Substring(i, 1);
            }

            for (int i = 0; i < panlin_str.Length; i++)
            {
                if (panlin_str[i].Equals(input_str[i]))
                
                    count_equal++;
                    
                else
                
                    count_notequal++;
                    
            }

            if (count_notequal ==0)
            {
                Console.WriteLine("\nPanlimdrome!!!!!!!!!!!!!!!!");
            }
            else if (count_notequal>0)
            {
                Console.WriteLine("Not Panlimdrome!!!!!!!!!!!!!!!!");
            }
        }
    }
}
