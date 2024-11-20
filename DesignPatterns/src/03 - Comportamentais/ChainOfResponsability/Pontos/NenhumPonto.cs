namespace DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

public class NenhumPonto : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo;

    public int CalcularPontos(Pedido pedido)
    {
        return 0;
    }

    public void SetProximo(ICalculadorDePontos proximo)
    {
    }
}