namespace vowels_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vowelsChar = "aeiouAEIOU";
            int count = 0;
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (vowelsChar.Contains(input[i]))
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of vowels character in {input} is {count}");
        }
    }
}
