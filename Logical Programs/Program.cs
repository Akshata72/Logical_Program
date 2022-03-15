

namespace LogicalPrograms
{
    class LogicalPrograms 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 For Fibonacci Series:");
            Console.WriteLine("Choose 2 For Perfect Number:");
            Console.WriteLine("Choose 3 For check Prime Number or Not:");
            Console.WriteLine("Choose 4 For Reverse the Number:");
            Console.WriteLine("Choose 5 For StopWatch:");



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
                case 3:
                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.Primenumber();
                    break;
                case 4:
                    ReverseNumber reversenumber = new ReverseNumber();
                    reversenumber.Reversenumber();
                    break;
                case 5:
                    StopWatch stopwatch = new StopWatch();
                    stopwatch.Stopwatch();
                    break;
                default:
                    Console.WriteLine("Invalied Input");
                    break;

            }




        }


    }

}