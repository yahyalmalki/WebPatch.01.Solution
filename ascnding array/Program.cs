namespace ascnding_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 8,1, 9, 6, 10 };
            int saveNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    saveNum = arr[i];
                    arr[i] = arr[j];
                        arr[j] = saveNum;
                }
            }
                
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
