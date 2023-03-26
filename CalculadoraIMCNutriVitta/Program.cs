
namespace CalculadoraIMCNutriVitta
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe CalculadoraIMC
            CalculadoraIMC calculadora = new CalculadoraIMC();

            // Chamando o método CalcularIMC e exibindo o resultado
            double peso = 70;
            double altura = 1.75;
            double imc = calculadora.CalcularIMC(peso, altura);
            Console.WriteLine("Seu IMC é: " + imc);

            // Chamando o método ClassificarIMC e exibindo o resultado
            string classificacao = calculadora.ClassificarIMC(imc);
            Console.WriteLine("Sua classificação de IMC é: " + classificacao);
        }
    }
}
