using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitCode = "";
            while(exitCode != "exit")
            {
                Console.WriteLine("Hello World!");

                Calculator newCalc = new Calculator();

                double result = newCalc.AddTest(2.5, 3);
                Console.WriteLine(result);
                exitCode = Console.ReadLine();
            }
        }
    }
}
