namespace DesignPatterns.Comportamentais.State.MachineState;

public class AguardandoPagamento : IState
{
    private Pedido Pedido {get; set;}

    public AguardandoPagamento(Pedido pedido)
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
        Console.WriteLine("Operação inválida: o pedido ainda não foi pago!");
    }

    public void Pagar()
    {
        Pedido.AlterarEstadoAtual(Pedido.Pago);
        Console.WriteLine("\nO pedido foi Pago!");
    }
}