using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays de Dimensões simples");

            string[] strArray = new string[]{

                "diclofenaco",
                "sertralina",
                "paroxetina",
                "mometasona"
            };
            //   leitura de arrays usando loop´foreach
            foreach (string strLoop in strArray)
            {
                Console.WriteLine(strLoop + "*****");
            }

            Console.WriteLine("#########################");
            Console.WriteLine(" Array de duas dimensões");

            string[,] string2DArray = new string[2, 2] { 
                 { "Ana","Paula"},
                    
                 {"moratense","aprofarma"}                      
            };
            foreach (string strlooP2 in string2DArray)
            {
                Console.WriteLine(strlooP2 + "%%%%%%%%%%");
            }

            Console.WriteLine("#####################");
            Console.WriteLine("jagged array");

            int[][] intJaggedArray3 =
            {
              
               new int[]{              
                   2, 12        
               },
               new int[]{
               14,14,24,34
               },
               new int[]{
               6,16,36,46,56
               }                                          
            };
            for (int i = 0; i < intJaggedArray3.Length; i++)
            {
                Console.Write("Element({0}):", i);
                for (int j = 0; j < intJaggedArray3[i].Length; j++)
                {
                    Console.Write("{0}{1}", intJaggedArray3[i][j], j == 
                        (intJaggedArray3[i].Length - 1) ? "" : "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}