using Atividade_PO3;
using System;



bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Valor do Produto:");
        int valorProduto = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor do Desconto:");
        int valorDesconto = int.Parse(Console.ReadLine());

        CalcDesconto soma = new CalcDesconto();

        Console.WriteLine(soma.CalcularDesconto(valorProduto, valorDesconto));

        prossiga = false;

    }
    catch (FormatException)
    {
        Console.WriteLine("Informe apenas numeros");
    }

} while (prossiga);