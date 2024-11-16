namespace DesignPatterns.Comportamentais.Strategy.Pedido;

public abstract class Pedido
{
    private decimal Valor { get; set; }
    public IFrete TipoFrete { get; set; }

    public Pedido(decimal valor)
    {
        Valor = valor;
    }    

    public decimal CalcularFrete()
    {
        if(TipoFrete == null) throw new Exception("Informe o tipode frete!");

        return TipoFrete.Calcular(Valor);
    }
}