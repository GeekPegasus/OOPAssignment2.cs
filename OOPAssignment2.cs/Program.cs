using System;
using System.IO;
using System.Linq;

namespace OOPAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = Console.ReadLine();
            string[] x = y.Split(" ");
            switch (x[0])
            {
                case "diff":
                    string[] file1 = File.ReadAllLines(x[1]);
                    string[] file2 = File.ReadAllLines(x[2]);
                    if (file1.SequenceEqual(file2))
                    {
                        Console.WriteLine("The files are the same.");
                    }
                    else
                    {
                        Console.WriteLine("The files are not the same.");
                    }
                    break;
            }


        }
    }
}
