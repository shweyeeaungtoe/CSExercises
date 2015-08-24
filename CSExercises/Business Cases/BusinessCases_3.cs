using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class BusinessCases_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:\t");
            String one_word = Console.ReadLine();
            //int i = Convert.ToInt32('A');
            //Console.WriteLine(i);

            Encrypt(one_word);
        }

        public static void Encrypt(String s)
        { 
         string [] s1=new string[s.Length];
         char [] c=new char[s.Length];

         int [] intarr=new Int32[s.Length];   

         char[] chararr = new char[s.Length];
             for (int i = 0; i < s.Length; i++)
            {

                c[i] = Convert.ToChar(s.Substring(i, 1));
         
                if (c[i].Equals('z') || c[i].Equals('Z') || c[i].Equals('9'))
                {
                    if (c[i].Equals('z'))
                        intarr[i] = 97;
                    if (c[i].Equals('Z'))
                        intarr[i] = 65;
                    if (c[i].Equals('9'))
                        intarr[i] = 48;

                    chararr[i] = Convert.ToChar(intarr[i]);
                    
                }
                else
                {
                   // int_c[i] = Convert.ToChar(c_int[i]);

                    intarr[i] = Convert.ToInt32(c[i] + 1);

                    chararr[i] = Convert.ToChar(intarr[i]);
                  
                }  
                  
            }
             Console.WriteLine("\nFirst Transformation is:\t");
             for (int i = 0; i < s.Length; i++)
             {

                 Console.Write(chararr[i]);
                
             }
             
             Console.WriteLine("\nSecond Transformation is:\t");
             for (int i = chararr.Length-1; i >=0 ; i--)
             {

                 Console.Write(chararr[i]);

             }
             Console.WriteLine("\n");
        }

    }
}
