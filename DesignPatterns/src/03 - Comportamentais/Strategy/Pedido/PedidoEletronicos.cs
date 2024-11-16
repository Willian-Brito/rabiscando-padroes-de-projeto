namespace DesignPatterns.Comportamentais.Strategy.Pedido;

public class PedidoEletronicos : Pedido
{
    public string NomeSetor { get; set; }

    public PedidoEletronicos(decimal valor) : base(valor)
    {
        NomeSetor = "Eletrônicos";
    }
}