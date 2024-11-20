namespace DesignPatterns.Estruturais.Facade.Vendas;

public class VendaFacade
{
    private Pedido Pedido;
    private Pagamento Pagamento;
    private EmailPedido Email;

    public VendaFacade(Consumidor consumidor)
    {
        Pedido = new Pedido(consumidor);
        Email = new EmailPedido(Pedido);
    }

    public void AddProduto(Produto produto)
    {
        Pedido.AddProduto(produto);
    }

    public void PagarComCredito()
    {
        Pagamento = new PagamentoCredito(Pedido);

        if(Pagamento.Pagar())
            Email.Enviar("Pagamento realizado com sucesso via credito!");
        else 
            Email.Enviar("Falha no pagamento via crédito");
    }

    public void PagarComBoleto()
    {
        Pagamento = new PagamentoBoleto(Pedido);

        if(Pagamento.Pagar())
            Email.Enviar("Pagamento realizado com sucesso via boleto!");
        else 
            Email.Enviar("Falha no pagamento via boleto");
    }
}