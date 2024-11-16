namespace DesignPatterns.Comportamentais.Strategy.Pedido;

public class PedidoMoveis : Pedido
{
    public string NomeSetor { get; set; }

    public PedidoMoveis(decimal valor) : base(valor)
    {
        NomeSetor = "Móveis";
    }
}