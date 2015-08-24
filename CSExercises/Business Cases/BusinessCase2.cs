using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class BusinessCase2
    {
      
        static void Main(string[] args)
        {
            Console.Write("Enter OLD CODE:\t");
            String old_code =Console.ReadLine();

            Console.Write("Enter Your Address:\t");
            String address = Console.ReadLine();

            String blk1=null;
            String blk=null;
             String blk2=null;

            string[,] arr = new string[,] { { "A", "1" }, { "B", "2" }, { "C", "3" }, { "D", "4" }, { "E", "5" }, { "F", "6" }, { "G", "7" }, { "H", "8" } };

          
            int blk_int=0;

            String[] code_fornew = new String[2];

              int j = 0;
              for (int i = old_code.Length - 2; i <= old_code.Length - 1; i++)
              {
                 code_fornew[j] = Convert.ToString(old_code.Substring(i, 1));
                
                  j++;
                }

              int count = 0;
                for (int i = address.Length - 1; i <= address.Length - 1; i++)
                { 
                      blk1=address.Substring(i,1);
                      for(int k=0; k<10; k++)
                       {
                           if (blk1.Equals(Convert.ToString(k)))
                           {
                               count++; ;
                           }    
                        }
                      if (count == 0)
                      {
                          blk = blk1.ToUpper();
                          blk2 = address.Substring(0, address.Length-1);
                      }
                      else
                      {
                          blk2 = address.Substring(0, address.Length);
                      }
                 }
                if (!blk.Equals(null))
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (blk.Equals(arr[i, 0]))
                        {
                            blk = arr[i, 1];
                        }
                        else
                            blk = "0";
                    }
              
              
                }

                Console.WriteLine("\nNew Code is\t");
                for (int i = 0; i < code_fornew.Length; i++)
                {
                    Console.Write(code_fornew[i]);
                }
                Console.Write("\t" + blk + "\t" + blk2 + "\n");
        }

            

    }
}
