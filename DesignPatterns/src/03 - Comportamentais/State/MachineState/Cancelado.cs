using DesignPatterns.Comportamentais.State;
using DesignPatterns.Comportamentais.State.MachineState;

public class Cancelado : IState
{
    private Pedido Pedido {get; set;}

    public Cancelado(Pedido pedido)
    {
        Pedido = pedido;
    }

    public void Cancelar()
    {
        Console.WriteLine("\nOperação inválida: o pedido já foi cancelado!");
    }

    public void Despachar()
    {
        Console.WriteLine("\nOperação inválida: o pedido se encontra cancelado!");
    }

    public void Pagar()
    {
        Console.WriteLine("\nOperação inválida: o pedido se encontra cancelado!");
    }
}