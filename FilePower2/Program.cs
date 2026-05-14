using System;
using System.IO;

namespace FilePower2
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

            using (StreamWriter sw = new StreamWriter(filename))
            {
                Console.Write("Enter lines of text: ");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "") break;
                    sw.WriteLine(input);
                }

                Console.WriteLine($"Saved to {filename}.");
            }
        }
    }
}
