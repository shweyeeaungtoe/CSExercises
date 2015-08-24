using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Business_Cases
{
    class BusinessCase2
    {
       /* static void Main(string[] args)
        {
            Console.Write("the ASCII num of A is " + Convert.ToInt32('A') + "\n");
            Console.Write("the ASCII num of 9 is " + Convert.ToInt32('9') + "\n");
            int temp, remain;
            int[] postcode = new int[6];
            char alpha;
            string blknum = null;
            Console.Write("pleasw input the old code :\n");
            int oldcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the block num:\n");
            string blk = Console.ReadLine();
            Console.Write("the old code" + oldcode + "\nblk num is " + blk + "\n");
           
            remain = oldcode - oldcode / 100 * 100;
            postcode[0] = remain / 10;
            postcode[1] = remain % 10;
            foreach (char item in blk)
            {
                if (item >= 48 && item <= 57)
                    blknum += item;
            }
            temp = int.Parse(blknum);
            postcode[3] = temp / 100;
            postcode[4] = (temp - postcode[3] * 100) / 10;
            postcode[5] = temp - postcode[3] * 100 - postcode[4] * 10;
            try
            {
                alpha = Convert.ToChar(blk[3]);
            }
            catch
            {
                alpha = 'A';
            }

            postcode[2] = Convert.ToInt32(alpha) - 64;
            for (int i = 0; i < 6; i++)
                Console.Write(postcode[i] + "\t");
        }*/

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
