using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive
{
    public interface IRentCostStrategy
    {

        string Definition();

        double Calculate();

    }
}
