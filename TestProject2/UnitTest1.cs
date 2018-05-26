using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rent.bike.intive;


namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer cli = new Customer();

            cli.Name = "Ricardo";
            cli.LastName = "Ledesma";

            Assert.AreEqual(cli.Name, "Ricardo");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Customer cli = new Customer();

            cli.Name = "Cosme";
            cli.LastName = "Fulanito";

            Assert.AreEqual(cli.LastName, "Fulanito");
        }

        [TestMethod]
        public void TestMethod3()
        {
            rent.bike.intive.Bike bici = new rent.bike.intive.Bike();
            bici.Available = true;
            bici.Model = 666;

            Assert.AreEqual(bici.Available, true);
            Assert.AreEqual(bici.Model, 666);
        }

        [TestMethod]
        public void TestMethod4()
        {

            IRentType rent = new RentByHour();

            rent.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };

            Assert.AreEqual(rent.CalculateTotal(), 5.0);
        }

        [TestMethod]
        public void TestMethod41()
        {

            IRentType rent = new RentByHour();
            rent.Customer = new Customer { Name = "Cosme", LastName = "Fulanito" };

            Assert.AreEqual(rent.Customer.Name, "Cosme");
        }

        [TestMethod]
        public void TestMethod42()
        {
            IRentType rent = new RentByHour();
            rent.Customer = new Customer { Name = "Nacho", LastName = "Gonzalez" };

            Assert.AreEqual(rent.Customer.LastName, "Gonzalez");
        }

        [TestMethod]
        public void TestMethod43()
        {
            IRentType rent = new RentByHour();
            rent.Customer = new Customer { Name = "Nacho", LastName = "Gonzalez" };

            Assert.AreNotEqual(rent.Customer, null);
        }

        [TestMethod]
        public void TestMethod44()
        {
            IRentType rent = new RentByDay();
            rent.Customer = new Customer { Name = "Thanos", LastName = "Dios" };

            Assert.AreNotEqual(rent.Customer, null);
        }

        [TestMethod]
        public void TestMethod45()
        {
            IRentType rent = new RentByWeek();
            rent.Customer = new Customer { Name = "Peter", LastName = "Parker" };

            Assert.AreNotEqual(rent.Customer, null);
        }

        [TestMethod]
        public void TestMethod46()
        {
            IRentTypeFamily rent = new RentForFamily();
            rent.Customer = new Customer { Name = "Peter", LastName = "Quill" };

            Assert.AreNotEqual(rent.Customer, null);
        }

        [TestMethod]
        public void TestMethod5()
        {
            IRentType rent = new RentByDay();
            Assert.AreEqual(rent.CalculateTotal(), 20.0);
        }

        [TestMethod]
        public void TestMethod51()
        {
            IRentType rent = new RentByDay();
            rent.Bike = new rent.bike.intive.Bike { Model = 33, Available = true };
            Assert.AreEqual(rent.Bike.Model, 33);
        }

        [TestMethod]
        public void TestMethod52()
        {
            IRentType rent = new RentByDay();
            rent.Bike = new rent.bike.intive.Bike { Model = 33, Available = true };

            Assert.AreNotEqual(rent.Bike.Available, false);
        }

        [TestMethod]
        public void TestMethod6()
        {
            IRentType rent = new RentByDay();

            rent.Bike = new rent.bike.intive.Bike { Model = 33, Available = true };

            Assert.AreEqual(rent.Description, "This is a rent by day type");
        }

        [TestMethod]
        public void TestMethod61()
        {
            IRentType rent = new RentByHour();

            rent.Customer = new Customer { Name = "Bart", LastName = "Simpsons" };

            Assert.AreEqual(rent.Description, "This is a rent by hour type");
        }

        [TestMethod]
        public void TestMethod62()
        {
            IRentTypeFamily rent = new RentForFamily();
            rent.DateFrom = new DateTime(2018, 5, 26);

            Assert.AreEqual(rent.Description, "This are rents for a family group");
        }

        [TestMethod]
        public void TestMethod63()
        {
           IRentType rent = new RentByWeek();

            Assert.AreEqual(rent.Description, "This is a rent by entire week");
        }

        [TestMethod]
        public void TestMethod7()
        {
            IRentType rent = new RentByWeek();
            
            Assert.AreEqual(rent.CalculateTotal(), 60.0);
        }

        [TestMethod]
        public void TestMethod8()
        {
            IRentTypeFamily rent = new RentForFamily();

            Assert.AreEqual(rent.CalculateTotal(), -30.0);
        }

        [TestMethod]
        public void TestMethod9()
        {
            IRentTypeFamily rent = new RentForFamily();
            rent.DateFrom = new DateTime(2018, 5, 26);
            
            Assert.AreEqual(rent.DateFrom.ToShortDateString(), "26/05/2018");
        }

        [TestMethod]
        public void TestMethod91()
        {
            IRentType rent = new RentByWeek();
            rent.DateFrom = new DateTime(2018, 5, 26);

            Assert.AreEqual(rent.DateFrom.ToShortDateString(), "26/05/2018");
        }

        [TestMethod]
        public void TestMethod92()
        {
            IRentType rent = new RentByDay();
            rent.DateFrom = new DateTime(2018, 5, 26);

            Assert.AreEqual(rent.DateFrom.ToShortDateString(), "26/05/2018");
        }

        [TestMethod]
        public void TestMethod93()
        {
            IRentType rent = new RentByHour();
            rent.DateFrom = new DateTime(2022, 9, 1);

            Assert.AreEqual(rent.DateFrom.ToShortDateString(), "01/09/2022");
        }

        [TestMethod]
        public void TestMethod94()
        {
            IRentTypeFamily rent = new RentForFamily();
            rent.DateTo = new DateTime(2018, 5, 26);

            Assert.AreEqual(rent.DateTo.ToShortDateString(), "26/05/2018");
        }

        [TestMethod]
        public void TestMethod95()
        {
            IRentType rent = new RentByWeek();
            rent.DateTo = new DateTime(2010, 8, 25);

            Assert.AreEqual(rent.DateTo.ToShortDateString(), "25/08/2010");
        }

        [TestMethod]
        public void TestMethod96()
        {
            IRentType rent = new RentByDay();
            rent.DateTo = new DateTime(1976, 9, 1);

            Assert.AreEqual(rent.DateTo.ToShortDateString(), "01/09/1976");
        }

        [TestMethod]
        public void TestMethod97()
        {
            IRentType rent = new RentByHour();
            rent.DateTo = new DateTime(1910, 9, 12);

            Assert.AreEqual(rent.DateTo.ToShortDateString(), "12/09/1910");
        }

        [TestMethod]
        public void TestMethod11()
        {
            IRentTypeFamily rent = new RentForFamily();

            Assert.AreNotEqual(rent.PrintTicket(), "");
        }

        [TestMethod]
        public void TestMethod12()
        {
            IRentType rent = new RentByWeek();            

            Assert.AreNotEqual(rent.PrintTicket(), "");
        }

        [TestMethod]
        public void TestMethod13()
        {
            IRentType rent = new RentByDay();
            Assert.AreNotEqual(rent.PrintTicket(), "");
        }

        [TestMethod]
        public void TestMethod14()
        {
            IRentType rent = new RentByHour();

            Assert.AreNotEqual(rent.PrintTicket(), "");
        }
    }
}
