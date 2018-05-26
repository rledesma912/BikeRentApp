using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive {
   public class RentContext {

      //La asociación simple la dejo para visibilidad del diagrama de clases
      public IRentCostStrategy IRentCostStrategy { get; set; }

      // Referencia a la interfaz
      private IRentCostStrategy rentStrategy;

      // Propiedad que establecerá un nuevo tipo de renta (cambio de estrategia)
      public IRentCostStrategy RentStrategy {
         get { return rentStrategy; }
         set { this.rentStrategy = value; }
      }

      public double CalculateRentCost()
      {
          return this.rentStrategy.Calculate();
      }

      // Mostrar la estrategia de calculo de costo
      public string GetCalculatedCost() {
         return this.rentStrategy.Definition();
      }

   }
}
