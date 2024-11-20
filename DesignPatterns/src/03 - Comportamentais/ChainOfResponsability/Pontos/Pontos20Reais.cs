namespace DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

public class Pontos20Reais : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo;

    public int CalcularPontos(Pedido pedido)
    {
        if (pedido.Valor >= 20)
            return (int)pedido.Valor / 10;

        return Proximo.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorDePontos proximo)
    {
        Proximo = proximo;
    }
}