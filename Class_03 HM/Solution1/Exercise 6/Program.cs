using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
           

          


            Console.Write("Enter Name");
            Console.Write("\n");
            string[] arrayNames = new string[1];
            string yesOrNo;

            

                 

            do
            {
                Array.Resize(ref arrayNames, arrayNames.Length + 1);
                arrayNames[arrayNames.Length - 1] = Console.ReadLine();
                Console.Write("Do you want another name?");
                yesOrNo = Console.ReadLine();


            } while (yesOrNo == "y");

            Console.Write("All Names:");
            for (int i = 0; i < arrayNames.Length; i++)
            {
                Console.Write(arrayNames[i] + "\n");
            }

            
           

           

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
