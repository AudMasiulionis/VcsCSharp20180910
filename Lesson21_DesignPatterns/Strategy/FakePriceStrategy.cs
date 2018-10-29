using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_DesignPatterns.Strategy
{
    class FakePriceStrategy : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return 99999;
        }
    }
}
