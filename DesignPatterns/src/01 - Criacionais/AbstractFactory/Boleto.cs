using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory;

public class Boleto
{
    protected decimal Valor {get; set;}
    protected IJuros Juros {get; set;}
    protected IDesconto Desconto {get; set;}
    protected IMulta Multa {get; set;}

    public Boleto(decimal valor, ICalculosFactory factory)
    {
        Valor = valor;
        Juros = factory.CriarJuros();
        Desconto = factory.CriarDesconto();
        Multa = factory.CriarMulta();
    }

    public decimal CalcularDesconto()
    {
        return Valor * Desconto.GetDesconto();
    }

    public decimal CalcularJuros()
    {
        return Valor * Juros.GetJuros();
    }

    public decimal CalcularMulta()
    {
        return Valor * Multa.GetMulta();
    }
}