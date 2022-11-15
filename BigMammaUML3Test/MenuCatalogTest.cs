using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UML3Poul;

namespace BigMammaUML3Test
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            IMenuCatalog catalog;
            catalog = new MenuCatalog();
            Pizza p1 = new Pizza(true, 1, "Vesuvio", "Tomat, Oliven, ost", 85, MenuType.Pizza);
            Pizza p2 = new Pizza(false, 2, "Hawaii", "Tomat, Ananas, ost", 75, MenuType.Pizza);


            //Act
            int antalBefore = catalog.Count;
            catalog.Add(p1);
            catalog.Add(p2);
            int antalAfter = catalog.Count;
            //Assert

            Assert.AreEqual(antalBefore + 2, antalAfter);
        }
    }
}