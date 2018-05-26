using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive {
   public class DayCostStrategy : IRentCostStrategy {

      public string Definition() {
          return "A rent by day : cost $" +this.Calculate().ToString();
      }


      public double Calculate() {
         return 20.0;
      }
   }
}
