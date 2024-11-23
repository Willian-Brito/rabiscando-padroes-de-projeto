namespace DesignPatterns.Comportamentais.Command.Comandos;

public class LigarArCondicionado : ICommand
{
    private ArCondicionado ArCondicionado;

    public LigarArCondicionado(ArCondicionado arCondicionado)
    {
        ArCondicionado = arCondicionado;
    }

    public void Desfazer()
    {
        ArCondicionado.Desligar();
        ArCondicionado.ImprimirObjeto();
    }

    public void Executar()
    {
        ArCondicionado.Ligar();
        ArCondicionado.ImprimirObjeto();
    }
}