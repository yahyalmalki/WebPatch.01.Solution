namespace Fibonacci_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //looping and get fibonacci numbers
            int fibonNum = 0;
            int lastNum = 1;
            int firstNum = 0;
            for (int i = 0; i <= 15; i++)
            {
                if (i <= 1)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    fibonNum = firstNum + lastNum;
                    Console.WriteLine(fibonNum);
                    firstNum = lastNum;
                    lastNum = fibonNum;

                }
                
                
            }
        }
    }
}
