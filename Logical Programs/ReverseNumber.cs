using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reversenumber()
        {
            Console.WriteLine("Enter a Number for Reverse:");
            int Number = int.Parse(Console.ReadLine());

            int Rev = 0;
            int Reverse = 0;
            
            while(Number != 0)
            {

                
                Rev = Number % 10;
                Reverse = Reverse * 10 + Rev;

                Number /= 10;
                
                



            }
            Console.WriteLine(Reverse);

            
        
        }

    }
}
