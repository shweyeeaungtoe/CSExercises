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
            Console.WriteLine("Please Enter one pharse:\t");
            String word = Console.ReadLine();

            String vowels=null,str=null;
            int count=0;

            int 
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
            Console.WriteLine("35(a)-----> Total number of vowels:\t"+count);



            for (int i = 0; i < word.Length; i++)
            {
                str = word.Substring(i, 1);

                switch (str)
                {
                    case 'a': ;
                    //vowels = str;
                    //Console.WriteLine("Vowels is\t"+vowels);
                }

            }



            
        }
    }
}
