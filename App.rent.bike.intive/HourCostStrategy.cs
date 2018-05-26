using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive {
   public class HourCostStrategy : IRentCostStrategy {

       public double Calculate()
       {
         return 5.0;
      }

      public string Definition() {
          return "A rent by hour: cost $" + this.Calculate().ToString();
      }

   }
}
