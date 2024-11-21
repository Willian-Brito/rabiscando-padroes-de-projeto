namespace DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

public interface ICalculadorDePontos
{
    int CalcularPontos(Pedido pedido);
    void SetProximo(ICalculadorDePontos proximo);
}