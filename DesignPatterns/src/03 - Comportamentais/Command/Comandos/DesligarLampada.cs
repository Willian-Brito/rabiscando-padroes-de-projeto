namespace DesignPatterns.Comportamentais.Command.Comandos;

public class DesligarLampada : ICommand
{
    private Lampada Lampada;

    public DesligarLampada(Lampada lampada)
    {
        Lampada = lampada;
    }

    public void Desfazer()
    {
        Lampada.Ligar();
        Lampada.ImprimirObjeto();
    }

    public void Executar()
    {
        Lampada.Desligar();
        Lampada.ImprimirObjeto();
    }
}