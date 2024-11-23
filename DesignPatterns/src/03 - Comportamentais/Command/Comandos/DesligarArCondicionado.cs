namespace DesignPatterns.Comportamentais.Command.Comandos;

public class DesligarArCondicionado : ICommand
{
    private ArCondicionado ArCondicionado;

    public DesligarArCondicionado(ArCondicionado arCondicionado)
    {
        ArCondicionado = arCondicionado;
    }

    public void Desfazer()
    {
        ArCondicionado.Ligar();
        ArCondicionado.ImprimirObjeto();
    }

    public void Executar()
    {
        ArCondicionado.Desligar();
        ArCondicionado.ImprimirObjeto();
    }
}