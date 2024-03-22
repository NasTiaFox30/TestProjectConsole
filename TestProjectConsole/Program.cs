using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProjectConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testowy projekt");

            Console.WriteLine("Randomiser");
            Random random = new Random();

            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(random.Next());
            }

        }
    }
}
