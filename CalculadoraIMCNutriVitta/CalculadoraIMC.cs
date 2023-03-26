using System;

namespace CalculadoraIMCNutriVitta
{
    public class CalculadoraIMC
    {
        public double CalcularIMC(double peso, double altura)
        {
            try
            {
                double imc = peso / (altura * altura);
                if (altura == 0) throw new DivideByZeroException();
                if (peso < 0) throw new Exception();
                return Math.Round(imc, 2);
            }
             catch(Exception e)
            {
                Console.WriteLine("Erro desconhecido ao calcular IMC: " + e.Message);
                throw e;
            }
           
        }

        public string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            else if (imc < 25)
            {
                return "Peso Normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc < 35)
            {
                return "Obesidade Grau I";
            }
            else if (imc < 40)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }
    }
}


