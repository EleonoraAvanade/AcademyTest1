using System;
using Week1_AC_Esercitazione.Chain_Of_Responsability;
using Week1_AC_Esercitazione.Factory;
using Week1_AC_Esercitazione.Factory.Categorie;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestChain1()
        {
            //ARRANGE
            //METTERE IMPORTO E VEDERE SE DA LA CATEGORIA GIUSTA
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            //ACT
            string res = manager.Handle(500);
            //Assert
            Assert.True(res.Contains("Manager"));
        }
        [Fact]
        public void TestChain2()
        {
            //ARRANGE
            //METTERE IMPORTO E VEDERE SE DA LA CATEGORIA GIUSTA
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            //ACT
            string res = manager.Handle(3100);
            //Assert
            Assert.True(res.Contains("Nessuno"));
        }
        [Fact]
        public void TestChain3()
        {
            //ARRANGE
            //METTERE IMPORTO E VEDERE SE DA LA CATEGORIA GIUSTA
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            //ACT
            string res = manager.Handle(1400);
            //Assert
            Assert.True(res.Contains("CEO"));
        }
        [Fact]
        public void TestChain4()
        {
            //ARRANGE
            //METTERE IMPORTO E VEDERE SE DA LA CATEGORIA GIUSTA
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            //ACT
            string res = manager.Handle(50);
            //Assert
            Assert.True(res.Contains("manager"));
        }
        [Fact]
        public void TestChain5()
        {
            //ARRANGE
            //METTERE IMPORTO E VEDERE SE DA LA CATEGORIA GIUSTA
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            //ACT
            string res = manager.Handle(350);
            //Assert
            Assert.True(res.Contains("manager"));
        }
        [Fact]
        public void TestFactory1()
        {
            //ARRANGE
            RimborsoFactory rimborsoFactory = new RimborsoFactory();
            //ACT
            IRimborso rimborso = null;
            rimborso = rimborsoFactory.GetRimborso("Viaggio");
            //Assert
            Assert.True(rimborso.Calcola(500) == 550);
        }
        [Fact]
        public void TestFactory2()
        {
            //ARRANGE
            RimborsoFactory rimborsoFactory = new RimborsoFactory();
            //ACT
            IRimborso rimborso = null;
            rimborso = rimborsoFactory.GetRimborso("Vitto");
            //Assert
            Assert.True(rimborso.Calcola(1400) == 980);
        }
        [Fact]
        public void TestFactory3()
        {
            //ARRANGE
            RimborsoFactory rimborsoFactory = new RimborsoFactory();
            //ACT
            IRimborso rimborso = null;
            rimborso = rimborsoFactory.GetRimborso("Altro");
            //Assert
            Assert.True(rimborso.Calcola(50) == 5);
        }

        [Fact]
        public void TestFactory4()
        {
            //ARRANGE
            RimborsoFactory rimborsoFactory = new RimborsoFactory();
            //ACT
            IRimborso rimborso = null;
            rimborso = rimborsoFactory.GetRimborso("Alloggio");
            //Assert
            Assert.True(rimborso.Calcola(350) == 350);
        }
    }
}
