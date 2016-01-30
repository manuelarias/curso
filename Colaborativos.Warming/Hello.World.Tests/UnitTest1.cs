using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.World.Tests.Client;

namespace Hello.World.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSayHelloMyName ()
        {
            // preparar el escenario
            string myName = "Héctor";
            string resultadoEsperado = "Hello World, Héctor";
            string resultadoReal;
            HelloWorldClient client = new HelloWorldClient();

            // invoco al método correspondiente
            resultadoReal = client.SayHello(myName);

            // comparación de resultados
            Assert.AreEqual(resultadoEsperado, resultadoReal);

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
