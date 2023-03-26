using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraIMCNutriVitta;
using System;

namespace TesteCalculadoraIMC
{
    [TestClass]
    public class TestesCalculadoraIMC
    {

        CalculadoraIMC calculadora = new CalculadoraIMC();
        double peso = 0.0;
        double altura = 0.0;
        double imcEsperado = 0.0;
        double imcCalculado = 0.0;
        string imcClassificacaoCalculada;
        string imcClassificacaoEsperada;


        [TestMethod]
        public void TesteIMCPesoNormal()
        {

            peso = 70;
            altura = 1.75;
            imcEsperado = 22.86;
            imcClassificacaoEsperada = "Peso Normal";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado, 0.01);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteIMCAbaixoDoPeso()
        {

            peso = 50;
            altura = 1.65;
            imcEsperado = 18.37;
            imcClassificacaoEsperada = "Abaixo do Peso";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteIMCSobrepeso()
        {

            peso = 85;
            altura = 1.75;
            imcEsperado = 27.76;
            imcClassificacaoEsperada = "Sobrepeso";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado, 0.01);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteIMCObesidadeGrauI()
        {
            peso = 100;
            altura = 1.75;
            imcEsperado = 32.65;
            imcClassificacaoEsperada = "Obesidade Grau I";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado, 0.01);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteIMCObesidadeGrauII()
        {
            peso = 120;
            altura = 1.75;
            imcEsperado = 39.18;
            imcClassificacaoEsperada = "Obesidade Grau II";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado, 0.01);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteIMCObesidadeGrauIII()
        {
            peso = 150;
            altura = 1.75;
            imcEsperado = 48.98;
            imcClassificacaoEsperada = "Obesidade Grau III";

            imcCalculado = calculadora.CalcularIMC(peso, altura);
            imcClassificacaoCalculada = calculadora.ClassificarIMC(imcCalculado);

            Assert.AreEqual(imcEsperado, imcCalculado, 0.01);
            Assert.AreEqual(imcClassificacaoEsperada, imcClassificacaoCalculada);
        }

        [TestMethod]
        public void TesteAlturaZero()
        {
            peso = 70;
            altura = 0.0;

            Assert.ThrowsException<DivideByZeroException>(() => calculadora.CalcularIMC(peso, altura));

        }

        [TestMethod]
        public void TestePesoInvalido()
        {
            peso = -70;
            altura = 1.75;

            Assert.ThrowsException<System.Exception>(() => calculadora.CalcularIMC(peso, altura));
        }
    }
}
