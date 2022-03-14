

namespace LogicalPrograms
{
    class LogicalPrograms 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 For Fibonacci Series:");
            Console.WriteLine("Choose 2 For Perfect Number:");

            int Option = int.Parse(Console.ReadLine());



            switch(Option)
            {
                case 1:
                    FibonacciSeries fibonacciseries = new FibonacciSeries();
                    fibonacciseries.Fibonacciseries();
                    break;
                case 2:
                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.PerfectNumbers();
                    break;

            }




        }


    }

}