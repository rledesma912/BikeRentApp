using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive {
   public class WeekCostStrategy: IRentCostStrategy {

       public double Calculate()
       {
         return 60.0;
      }

      public string Definition() {
          return "A rent by week: cost $";
      }
   }
}
