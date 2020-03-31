using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] array = new string[3][];
            array[0] = new string[3] {"main", "up", "sub" };
            array[1] = new string[3] { "down", "center", "up" };
            array[2] = new string[3] { "sub", "down", "main" };

            foreach (string[] row in array)
            {
                foreach (string col in row)
                {
                    Console.Write(col+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
