namespace Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
            
    }
}
