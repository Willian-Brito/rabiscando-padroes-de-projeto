namespace DesignPatterns.Estruturais.Facade.Vendas;

public class EmailPedido
{
    private Pedido Pedido;

    public EmailPedido(Pedido pedido)
    {
        Pedido = pedido;
    }

    public void Enviar(string mensagem)
    {
        Console.WriteLine($"\nEmail enviado para {Pedido.Consumidor.Email}");
        Console.WriteLine($"\nMensagem: {mensagem}");
    }
}