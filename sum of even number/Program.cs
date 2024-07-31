namespace sum_of_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
                    Console.WriteLine($"the sum of even number from 1 to 100 is {sum}");
        }
    }
}
