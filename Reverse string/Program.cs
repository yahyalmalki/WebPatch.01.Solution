using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Yahya";
            Console.WriteLine(name);
            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i]);

            }
        }
    }
}
