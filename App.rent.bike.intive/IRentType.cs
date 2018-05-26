using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive
{
    public interface IRentType
    {
        string Description { get; }

        Customer Customer { get; set; }

        Bike Bike { get; set; }

        DateTime DateFrom { get; set; }

        DateTime DateTo { get; set; }

        string PrintTicket();

        double CalculateTotal();
        
    }   

}
