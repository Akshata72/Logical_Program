using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNumbers()
        {
            Console.WriteLine("Enter a Number:");
            int Number = int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int i=1; i<Number; i++)
            {
                if( Number % i == 0)
                {
                     Sum += i; 
                    Console.WriteLine("Factors:" +i);
                    
                }
                


            }
            Console.WriteLine(Sum);
            if (Number == Sum)
            {
                Console.WriteLine("{0} is a Perfect Number..",Number);

            }
            else
            {

                Console.WriteLine("{0} is Not a Perfect Number..", Number);
            }

        }

    }
}
