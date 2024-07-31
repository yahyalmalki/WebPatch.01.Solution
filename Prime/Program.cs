namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num%i == 0)
                {
                    isPrime = false;
                }
                
            }
            
            String prime = isPrime? "prime" : "not prime";

            Console.WriteLine($"The number {num} is {prime}");
        }
    }
}
