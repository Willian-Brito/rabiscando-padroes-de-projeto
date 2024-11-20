namespace DesignPatterns.Criacionais.FactoryMethod.Abstract;

public abstract class Banco
{
    public Boleto GerarBoleto(int vencimento, decimal valor)
    {        
        var boleto = CriarBoleto(vencimento, valor);

        Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
        Console.WriteLine($"Juros: R$ {boleto.CalcularJuros()}");
        Console.WriteLine($"Desconto: R$ {boleto.CalcularDesconto()}");
        Console.WriteLine($"Multa: R$ {boleto.CalcularMulta()}");
        Console.WriteLine("\n---------\n");

        return boleto;
    }

    public abstract Boleto CriarBoleto(int vencimento, decimal valor);
}