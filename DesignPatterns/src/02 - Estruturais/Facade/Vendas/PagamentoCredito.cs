namespace DesignPatterns.Estruturais.Facade.Vendas;

public class PagamentoCredito : Pagamento
{
    public PagamentoCredito(Pedido pedido) : base(pedido) { }

    public override bool Pagar()
    {
        if(Pedido.Valor > 0)
            return true;
        return false;
    }
}