using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestsSumas
    {
        [TestMethod]
        public void UnoMasCuatro()
        {
            //Definicion del escenario
            Numero elPrimerOperando = new Numero("1", 10);
            Numero elSegundoOperando = new Numero("4", 10);
            char elOperador = '+';
            Numero elResultadoEsperado = new Numero("5", 10);
            Numero elResultadoReal;

            //Invoque al metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que el esperado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

        [TestMethod]
        public void SumaConDecimales()
        {
            //Definicion del escenario
            Numero elPrimerOperando = new Numero("1.3", 10);
            Numero elSegundoOperando = new Numero("-9.5", 10);
            char elOperador = '+';
            Numero elResultadoEsperado = new Numero("-8.2", 10);
            Numero elResultadoReal;

            //Invoque al metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que el esperado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }
    }
}
