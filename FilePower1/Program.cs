using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Provide a filename as arg.");
                return;
            }

            string filename = args[0];
            Queue<string> lines = new Queue<string>();

            Console.Write("Enter lines of text: ");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") break;
                lines.Enqueue(input);
            }

            File.WriteAllLines(filename, lines);
            Console.WriteLine($"Saved to {filename}.");
        }
    }
}
