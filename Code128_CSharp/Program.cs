using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code128_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            var sandbox = new Sandbox();
            Console.WriteLine("Creating Array");
            sandbox.CreateArray();
            Console.WriteLine("Ending");
            Console.ReadLine();
        }
    }
}
