using DesignPatterns.Comportamentais.State;
using DesignPatterns.Comportamentais.State.MachineState;

public class Enviado : IState
{
    private Pedido Pedido {get; set;}

    public Enviado(Pedido pedido)
    {
        Pedido = pedido;
    }

    public void Pagar()
    {
        Console.WriteLine("\nOperação inválida: o pedido já foi pago e enviado!");
    }

    public void Despachar()
    {
        Console.WriteLine("\nOperação inválida: o pedido já foi enviado!");
    }

    public void Cancelar()
    {
        Console.WriteLine("\nOperação inválida: o pedido já foi enviado!");
    }
}