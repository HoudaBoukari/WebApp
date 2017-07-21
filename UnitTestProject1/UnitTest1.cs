using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            var controller = new ValuesController();

            //Act
           int r = controller.Multiplication(2,5);

            //Assert
            Assert.AreEqual(10, r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            var controller = new ValuesController();

            //Act
            int r = controller.addition(2, 5);

            //Assert
            Assert.AreEqual(7, r);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange 
            var controller = new ValuesController();

            //Act
            int r = controller.addition(8, 5);

            //Assert
            Assert.AreEqual(13, r);
        }
    }
}
