using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {

               String a = "institute of system science";
               int number = a.Length;
               string[] s = new string[number];

               for (int i = 0; i < a.Length; i++)
               {
                   s[i] = a.Substring(i,1);
               
               
               }
               for (int i = 0; i < a.Length; i++)
               {
                   if (i == 0)
                   {
                       string value = (s[i]).ToUpper();

                       s[i] = value;
                   }

                   if (s[i].Equals(" "))
                   { 
                     string value=(s[i+1]).ToUpper();

                     s[i + 1] = value;
                   }
               }
               Console.Write(a + "=>\t");
               for (int i = 0; i < a.Length; i++)
               {
                   Console.Write(s[i]);
                  
               }
               Console.WriteLine("\n");
            
               
               
        }
    }
}
