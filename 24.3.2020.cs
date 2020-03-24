using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Write a number for the array length - ");
            string a = Console.ReadLine();
            Console.WriteLine("Write a number to multiply the index numbers - ");
            string b = Console.ReadLine();

            //setup array
            int i;
            int lng = Convert.ToInt32(a);
            int multi = Convert.ToInt32(b);
            int[] arr = new int[lng];
            for (i = 0; i < lng; i++)
                arr[i] = i;
            for (i = 0; i < lng; i++)
                arr[i] *= multi;
            
            //Output
            Console.WriteLine($"Number of elements - {lng}");
            Console.WriteLine($"Multiplication number - {multi}");
            Console.Write("Array content: ");
            for (i = 0; i < lng; i++)
                Console.Write($"{arr[i]}, ");

            Console.ReadKey();
        }
    }
}
