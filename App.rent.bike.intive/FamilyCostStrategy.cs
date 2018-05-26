using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive
{
    public class FamilyCostStrategy: IRentCostStrategy
    {
        public double Calculate()
        {
            return -30.0;
        }

        public string Definition()
        {
            return "A rent by Family promotion: cost of rents plus 30 percent off";
        }
    }
}
