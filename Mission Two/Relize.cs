using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_Two
{
    internal class Relize : Calculator
    {
        ILogger logger;
        Calculator calc;
        public Relize(ILogger logger )
        {
            this.logger = logger;
            calc  = new Calculator();
        }

        public int CheckAndSum (int a,int b)
        {

            if (a == 0 || b == 0)
            {
                logger.Error("Суммировать ноль смысла не имеет");
               return calc.Sum(a, b);
            }
            logger.Event("Сумма чисел состовляет");
            return calc.Sum(a, b);
        }
        
       
    }
}
