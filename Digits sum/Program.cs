namespace Digits_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            char digit = '0';
            

            for (int i = 0; i < num.ToString().Length; i++)
            {
                digit = num.ToString()[i];
                sum += int.Parse(digit.ToString());
                
            }

            Console.WriteLine($"The sum of digit is equal {sum}");
        }
    }
}
