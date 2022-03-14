using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {

        public void Fibonacciseries()
        {
            int Number1 = 0;
            int Number2 = 1;
            int Number3;
            Console.WriteLine("Enter the Number of Elements:");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i < Number; i++)
            {
                Number3 = Number1 + Number2;
                Console.WriteLine(Number3);
                Number1 = Number2;
                Number2 = Number3;


            }



        }


    }

}





