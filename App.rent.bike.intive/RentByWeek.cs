using System;

namespace rent.bike.intive
{
    public class RentByWeek : IRentType
    {
        private RentContext contexto;

        public string Description
        {
            get { return "This is a rent by entire week"; }
        }

        public Customer Customer { get; set; }

        public Bike Bike { get; set; }

        public RentByWeek()
        {
            contexto = new RentContext();
            IRentCostStrategy rent = new WeekCostStrategy();
            contexto.RentStrategy = rent;
        }

        public double CalculateTotal()
        {
            return this.contexto.CalculateRentCost();
        }

        public string PrintTicket()        
        {
            string msj = string.Empty;
            if (this.Customer == null) { msj = "¡The Rent need a customer asociated!\n"; }

            if (this.Bike == null) { msj += "¡The rent needs at least one bike!\n"; }

            msj += this.Description + "\n";
            msj += this.contexto.GetCalculatedCost();

            return msj;
        }
        
        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
    }
}
