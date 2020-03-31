using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] array = new string[3][];
            array[0]= new string[3];
            array[1] = new string[3];
            array[2] = new string[3];
            for (int rows = 0; rows < array.Length; rows++)
            {
                for (int cols = 0; cols < array.Length; cols++)
                {
                    if (rows == cols && rows + cols == array.Length - 1)
                        array[rows][cols] = "centre";
                    else if (cols == rows)
                        array[rows][cols] = "main";
                    else if (cols + rows == array.Length - 1)
                        array[rows][cols] = "sub";
                    else if (rows<cols)
                        array[rows][cols] = "up";
                    else if (rows>cols)
                        array[rows][cols] = "down";
                }
            }
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
