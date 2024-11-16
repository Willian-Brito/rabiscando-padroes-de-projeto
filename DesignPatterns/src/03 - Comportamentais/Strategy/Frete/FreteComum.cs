namespace DesignPatterns.Comportamentais.Strategy.Frete;

public class FreteComum : IFrete
{
    public decimal Calcular(decimal valorPedido)
    {
        return valorPedido * 0.05M;
    }
}