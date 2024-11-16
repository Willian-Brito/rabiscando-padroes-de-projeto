namespace DesignPatterns.Comportamentais.Strategy.Frete;

public class FreteExpresso : IFrete
{
    public decimal Calcular(decimal valorPedido)
    {
        return valorPedido * 0.1M;
    }
}
