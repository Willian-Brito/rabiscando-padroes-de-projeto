namespace DesignPatterns.Criacionais.FactoryMethod.Abstract;

public abstract class Boleto
{
    protected decimal Valor {get; set;}
    protected decimal Juros {get; set;}
    protected decimal Desconto {get; set;}
    protected decimal Multa {get; set;}

    public Boleto(decimal valor)
    {
        Valor = valor;
    }

    public decimal CalcularDesconto()
    {
        return Valor * Desconto;
    }

    public decimal CalcularJuros()
    {
        return Valor * Juros;
    }

    public decimal CalcularMulta()
    {
        return Valor * Multa;
    }
}