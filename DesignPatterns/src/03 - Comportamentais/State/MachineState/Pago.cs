using DesignPatterns.Comportamentais.State;
using DesignPatterns.Comportamentais.State.MachineState;

public class Pago : IState
{
    private Pedido Pedido {get; set;}

    public Pago(Pedido pedido)
    {
        Pedido = pedido;
    }

    public void Cancelar()
    {
        Pedido.AlterarEstadoAtual(Pedido.Cancelado);
        Console.WriteLine("\nO pedido foi cancelado!");
    }

    public void Despachar()
    {
        Pedido.AlterarEstadoAtual(Pedido.Enviado);
        Console.WriteLine("\nO pedido foi despachado!");
    }

    public void Pagar()
    {
        Console.WriteLine("\nOperação inválida: o pedido já foi pago!");
    }
}