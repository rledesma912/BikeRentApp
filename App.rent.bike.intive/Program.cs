using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent.bike.intive
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bici = new Bike();
            bici.Available = true;
            bici.Model = 666;

            IRentType rent = new RentByHour();

            rent.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };
            rent.Bike = bici;
            Console.WriteLine(rent.PrintTicket());
            
            Console.WriteLine("*****************************************");

            rent = null;
            rent = new RentByDay();

            rent.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };
            rent.Bike = new Bike { Available = true, Model = 3 };
            Console.WriteLine(rent.PrintTicket());

            Console.WriteLine("*****************************************");

            rent = null;
            rent = new RentByWeek();

            rent.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };
            rent.Bike = new Bike { Available = true, Model = 3 };
            Console.WriteLine(rent.PrintTicket());
            
            Console.WriteLine("*****************************************");

            //Habría que implementar un abstract factory para delegar la responsabilidad
            //de creacion de los tipos de alquiler.
            IRentTypeFamily rent2 = new RentForFamily();

            rent2.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };

            Console.WriteLine(rent2.CalculateTotal());
            Console.WriteLine(rent2.PrintTicket());

            Console.WriteLine("*****************************************");

            Console.ReadLine();
                       
        }
    }
}
