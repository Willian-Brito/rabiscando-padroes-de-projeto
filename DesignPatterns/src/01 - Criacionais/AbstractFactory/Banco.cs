using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory;

public class Banco
{
    public Boleto GerarBoleto(decimal valor, ICalculosFactory factory)
    {        
        var boleto = new Boleto(valor, factory);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Juros: R$ {boleto.CalcularJuros()}");
        Console.WriteLine($"Desconto: R$ {boleto.CalcularDesconto()}");
        Console.WriteLine($"Multa: R$ {boleto.CalcularMulta()}");
        Console.WriteLine("\n---------\n");

        return boleto;
    }
}