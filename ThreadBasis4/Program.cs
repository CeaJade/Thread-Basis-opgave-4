using System;
using System.Linq;
using System.Threading;

namespace ThreadBasis4
{
    class Program
    {
        static char output = '*';

        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(50);
                Thread printer = new Thread(Print);
                Thread reader = new Thread(Read);
                printer.Start();
                reader.Start();
            }
        }

        static void Print()
        {
            Console.Write(output);
        }

        static void Read()
        {
            if (!char.TryParse(Console.ReadLine(), out char input))
            {
                return;
            }
            output = input;
        }
    }
}
