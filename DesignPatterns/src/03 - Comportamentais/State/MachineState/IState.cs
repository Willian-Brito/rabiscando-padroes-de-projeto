namespace DesignPatterns.Comportamentais.State.MachineState;

public interface IState
{
    void Pagar();
    void Despachar();
    void Cancelar();
}