using DesignPatterns.Comportamentais.ChainOfResponsability.Pontos;

namespace DesignPatterns.Comportamentais.ChainOfResponsability;

public class ChainOfResponsability
{
    public static void Executar()
    {
        var pedido = new Pedido();
        var calculadoraDePontos = new CalculadoraDePontos();

        pedido.Valor = 21;

        Console.WriteLine($"Dia 15 {calculadoraDePontos.CalcularPontosDoPedido(pedido, 15)} pontos\n");
        Console.WriteLine($"Dia 16 {calculadoraDePontos.CalcularPontosDoPedido(pedido, 16)} pontos\n");

        Console.WriteLine("--------------\n");

        pedido.Valor = 100;

        Console.WriteLine($"Dia 15 {calculadoraDePontos.CalcularPontosDoPedido(pedido, 15)} pontos\n");
        Console.WriteLine($"Dia 16 {calculadoraDePontos.CalcularPontosDoPedido(pedido, 16)} pontos\n");
    }
}