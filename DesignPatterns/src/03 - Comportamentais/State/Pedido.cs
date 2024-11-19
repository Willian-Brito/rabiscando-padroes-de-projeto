using DesignPatterns.Comportamentais.State.MachineState;

namespace DesignPatterns.Comportamentais.State;

public class Pedido
{
    public IState AguardandoPagamento {get; private set;}
    public IState Pago {get; private set;}
    public IState Cancelado {get; private set;}
    public IState Enviado {get; private set;}
    public IState EstadoAtual {get; private set;}

    public Pedido()
    {
        AguardandoPagamento = new AguardandoPagamento(this);
        Pago = new Pago(this);
        Cancelado = new Cancelado(this);
        Enviado = new Enviado(this);
        
        AlterarEstadoAtual(AguardandoPagamento);
    }

    public void Pagar()
    {
        EstadoAtual.Pagar();
    }

    public void Despachar()
    {
        EstadoAtual.Despachar();
    }

    public void Cancelar()
    {
        EstadoAtual.Cancelar();
    }

    public void AlterarEstadoAtual(IState estadoAtual) 
    {
        EstadoAtual = estadoAtual;
    }
}