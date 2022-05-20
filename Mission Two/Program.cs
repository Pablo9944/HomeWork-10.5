using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Calculator();
            Relize r = new Relize(logger);
            int result = r.CheckAndSum(0,7);
            Console.WriteLine(result);

        }

    }

    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }

    class Calculator : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public int Sum(int a,int b)
        {
            return a + b;
            
        }
    }


}
