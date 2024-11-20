namespace DesignPatterns.Estruturais.Facade.Vendas;

public class PagamentoBoleto : Pagamento
{
    public PagamentoBoleto(Pedido pedido) : base(pedido) { }

    public override bool Pagar()
    {
        if(Pedido.Valor > 0)
            return true;
        return false;
    }
}