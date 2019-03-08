using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 20 Integers");
            int[] arrayInt = new int[20];

            for (var i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Your array!");


            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine(arrayInt[i]);
                
                if (arrayInt[i] == 0) {

                    Console.WriteLine("Skipped");
                    continue;
                }
                if (Math.Abs(arrayInt[i]
                    ).ToString().Length == 3) {
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
