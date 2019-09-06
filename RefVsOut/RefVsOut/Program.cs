using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVsOut
{

    /// <summary>
    /// !!! 3 złote zasady
    /// 1. out i ref są słowami kluczowymi C#, które pomagają przekazać referencje.
    /// 2. ref - przekazuje wartość i referencję (działanie dwustronne)
    /// 3. out - przekazuje referencję, ale nie wartość (działanie jednostronne)
    /// </summary>
    class Program
    {
        static int outsideInt = 20;

        static void Main(string[] args)
        {
            int outsideInt = 20;
            someMethod(out outsideInt);

            Console.WriteLine(outsideInt);
            Console.ReadLine();
        }

        private static void someMethod(out int insideInt)
        {
            insideInt = 0;
            insideInt = insideInt + 10;
        }
    }
}
