using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace OnExceptionAspect
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            try
            {
                MethodThrowingException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        [DatabaseExceptionWrapper]
        static void MethodThrowingException()
        {
            throw new ArgumentException("MyException");
        }
    }
}
