using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int debugNumber = 0;
#if DEBUG
            Debug.Assert(debugNumber > 0);
            Console.WriteLine("The debugNumber in debug is: " + debugNumber);
#endif
#if !DEBUG
            debugNumber++;
            Console.WriteLine("The debugNumber not in debug is: " + debugNumber);
#endif 
            Console.ReadKey();
        }
    }
}
