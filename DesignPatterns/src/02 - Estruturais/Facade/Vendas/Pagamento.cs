namespace DesignPatterns.Estruturais.Facade.Vendas;

public abstract class Pagamento
{
    protected Pedido Pedido;

    public Pagamento(Pedido pedido)
    {
        Pedido = pedido;
    }

    public abstract bool Pagar(); 
}