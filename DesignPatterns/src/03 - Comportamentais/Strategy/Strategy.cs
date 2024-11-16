using DesignPatterns.Comportamentais.Strategy.Frete;
using DesignPatterns.Comportamentais.Strategy.Pedido;

namespace DesignPatterns.Comportamentais.Strategy;

public class Strategy
{
    public static void Executar()
    {
        #region Pedidos Eletronicos        
        var pedidoEletronicos = new PedidoEletronicos(100);
        pedidoEletronicos.TipoFrete = new FreteComum();

        Console.WriteLine($"\nTipo Pedido: {pedidoEletronicos.NomeSetor}");
        Console.WriteLine($"\nFrete Comum: R$ {pedidoEletronicos.CalcularFrete()}");

        pedidoEletronicos.TipoFrete = new FreteExpresso();

        Console.WriteLine($"\nFrete Expresso: R$ {pedidoEletronicos.CalcularFrete()}");
        #endregion

        #region Pedidos Móveis

        Console.WriteLine("\n------------------------");
                        
        var pedidoMoveis = new PedidoMoveis(200);
        pedidoMoveis.TipoFrete = new FreteComum();

        Console.WriteLine($"\nTipo Pedido: {pedidoMoveis.NomeSetor}");
        Console.WriteLine($"\nFrete Comum: R$ {pedidoMoveis.CalcularFrete()}");

        pedidoMoveis.TipoFrete = new FreteExpresso();

        Console.WriteLine($"\nFrete Expresso: R$ {pedidoMoveis.CalcularFrete()}");
        #endregion
    }
}