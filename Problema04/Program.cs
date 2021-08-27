using NLog;
using System;

namespace Problema04
{
    class Program
    {
        private static readonly Logger myLogger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);

            }
            catch (FormatException fe)
            {
                myLogger.Error(fe.ToString());
                Console.WriteLine("Error: datos inválidos");
            }
            
            Console.ReadLine();
        }
    }
}
