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
            //*************************36(a)******************************************
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

            //////////////////////////////////////////////////////////////////////////////
            //**********************************36(b)***************************************
            Console.Write("\n\n---------------------------------------------------------------------\n\n");
             Console.Write("36(b)-----> Please Enter one pharse:\t");
             string word1 = (Console.ReadLine()).ToLower();
         
       
             string replaced_word1 = word1.Replace(" ","");
             string replaced_word2 = replaced_word1.Replace(".", "");


             int number1 = replaced_word2.Length;

             String[] panlin_str1 = new String[number1];
             String[] input_str1 = new String[number1];
             int count_equal1 = 0;
             int count_notequal1 = 0;
             int index1 = 0;
        

             for (int i = 0; i < replaced_word2.Length; i++)
             {
                 index1 += 1;


                 panlin_str1[i] = replaced_word2.Substring(replaced_word2.Length - index1, 1);
                 input_str1[i] = replaced_word2.Substring(i, 1);
             }

             for (int i = 0; i < panlin_str1.Length; i++)
             {
                 if (panlin_str1[i].Equals(input_str1[i]))

                     count_equal1++;

                 else

                     count_notequal1++;

             }

             if (count_notequal1 == 0)
             {
                 Console.WriteLine("\nPanlimdrome!!!!!!!!!!!!!!!!");
             }
             else if (count_notequal1 > 0)
             {
                 Console.WriteLine("\nNot Panlimdrome!!!!!!!!!!!!!!!!\n");
             }

             
        }
    }
}
