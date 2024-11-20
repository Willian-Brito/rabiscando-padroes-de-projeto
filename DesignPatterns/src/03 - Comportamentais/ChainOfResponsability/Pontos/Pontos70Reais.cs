namespace DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

public class Pontos70Reais : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo;

    public int CalcularPontos(Pedido pedido)
    {
        if (pedido.Valor >= 70)
            return (int)pedido.Valor / 5;

        return Proximo.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorDePontos proximo)
    {
        Proximo = proximo;
    }
}