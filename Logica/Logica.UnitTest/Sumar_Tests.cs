using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logica.UnitTest
{
    [TestClass]
    public class Sumar_Tests
    {
        [TestMethod]
        public void ProbarQueSumaEnteros()
        {
            float esperado = 3;

            Calculadora prueba = new Calculadora();
            float obtenido = prueba.Sumar(1, 2);

            Assert.AreEqual(esperado, obtenido);

        }

        [TestMethod]
        public void ProbarQueSumaFlotantes()
        {
            float esperado = 1.1F;
            Calculadora prueba = new Calculadora();
            float obtenido = prueba.Sumar(1, 0.1F);

            Assert.AreEqual(esperado, obtenido);

        }
    }
}
