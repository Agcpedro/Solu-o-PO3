using System;

namespace Atividade_PO3
{
    public class CalcDesconto
    {
        public float CalcularDesconto(float valorDoProduto, float valorDoDesconto)
        {

            float valorDescontado = valorDoProduto * (valorDoDesconto / 100);
            float valorFinal = valorDoProduto - valorDescontado;

            Console.WriteLine("O valor do produto com desconto é: " + valorFinal);

            return valorFinal;
        }
    }
}
