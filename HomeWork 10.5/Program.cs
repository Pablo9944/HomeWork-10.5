using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Relize r = new Relize();
            ICalculator i = new Relize();
            Console.WriteLine(i.Sum(0, 7));



        }
    }

   public interface ICalculator
    {
        int Sum(int a,int b);
    }

  public  class Relize : ICalculator
    {
      public  int Sum(int a, int b)
        {
            int c = 0;
            while (true)
            {
                try
                {
                    c = a + b;
                    if (a == 0 || b == 0)
                        throw new Exception("Ноль суммировать нет смысла");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                return c;
            }
            
        }

    }
}
