using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Console.WriteLine($"Hello World from {RuntimeInformation.OSDescription}");
        }
    }
}
