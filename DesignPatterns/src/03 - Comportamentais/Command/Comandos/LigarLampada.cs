namespace DesignPatterns.Comportamentais.Command.Comandos;

public class LigarLampada : ICommand
{
    private Lampada Lampada;

    public LigarLampada(Lampada lampada)
    {
        Lampada = lampada;
    }

    public void Desfazer()
    {
        Lampada.Desligar();
        Lampada.ImprimirObjeto();
    }

    public void Executar()
    {
        Lampada.Ligar();
        Lampada.ImprimirObjeto();
    }
}