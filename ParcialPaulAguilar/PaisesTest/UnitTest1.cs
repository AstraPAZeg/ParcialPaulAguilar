using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialPaulAguilar.Controllers;

namespace PaisesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetPaises()
        {
            //Arrange
            PaisesController controlador = new PaisesController();
            //Act
            var listaPaises = controlador.GetPaises();

            //Assert
        }
    }
}
