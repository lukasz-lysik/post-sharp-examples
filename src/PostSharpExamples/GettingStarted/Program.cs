using System.Diagnostics;
using System;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            SayHello();
            SayGoodBye();

            Console.ReadLine();
        }

        [Trace("MyCategory")]
        private static void SayHello()
        {
            Console.WriteLine("Hello, world.");
        }

        [Trace("MyCategory")]
        private static void SayGoodBye()
        {
            Console.WriteLine("Good bye, world.");
        }
    }
}
