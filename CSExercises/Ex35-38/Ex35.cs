using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("35(a)-----> Please Enter one pharse:\t");
            String word = (Console.ReadLine()).ToLower();

            String str=null;
            int count=0;

            for (int i = 0; i < word.Length; i++)
            {
                 str = word.Substring(i,1);
                 if (str.Equals("a") || str.Equals("e") || str.Equals("i") || str.Equals("o") || str.Equals("u"))
                 {
                      count++;
                     //vowels = str;
                     //Console.WriteLine("Vowels is\t"+vowels);
                 }
                
            }
            Console.WriteLine("Total number of vowels:\t"+count);


            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("\n\n35(b)-----> Please Enter one pharse:\t");
            String word1 = (Console.ReadLine()).ToLower();

            String str1 = null;
          
            int a_count = 0, e_count = 0, i_count = 0, o_count = 0, u_count = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                str1 = word1.Substring(i, 1);
                if (str1.Equals("a"))
                {
                    a_count++;
                   
                }
                if (str1.Equals("e"))
                {
                    e_count++;

                }
                if (str1.Equals("i"))
                {
                    i_count++;

                }
                if (str1.Equals("o"))
                {
                    o_count++;

                }
                if (str1.Equals("u"))
                {
                    u_count++;

                }
            }

            Console.WriteLine("Number of a:\t" + a_count + "\n" + "Number of e:\t" + e_count + "\n" + "Number of i:\t" + i_count + "\n" + "Number of o:\t" + o_count + "\n" + "Number of u:\t" + u_count + "\n");

            
        }
    }
}
