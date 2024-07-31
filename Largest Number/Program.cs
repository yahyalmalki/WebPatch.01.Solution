namespace Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] {1,9,6,10};

            int largestNum = arr[0];
            for (int i = 0; i < 4; i++)
            {
                if (largestNum < arr[i])
                {
                    largestNum = arr[i];
                }
            }

            Console.WriteLine($"The largest number on the list is {largestNum}");
        }
    }
}
