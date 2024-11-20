namespace DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

public class Pontos40Reais : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo;

    public int CalcularPontos(Pedido pedido)
    {
        if (pedido.Valor >= 40)
            return (int)pedido.Valor / 7;

        return Proximo.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorDePontos proximo)
    {
        Proximo = proximo;
    }
}