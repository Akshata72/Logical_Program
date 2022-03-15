using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void Primenumber()
        {
            int Count = 0;
            Console.WriteLine("Enter a number to check it is Prime or Not:");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                
                if (Number % i == 0)
                {
                    Count++;
                }



            }
                 if (Count == 2)
                 {

                    Console.WriteLine("It is a Prime Number...");
                 }
                 else
                 {

                    Console.WriteLine("It is a not Prime Number...");
                 }

            

        }


    }
}
