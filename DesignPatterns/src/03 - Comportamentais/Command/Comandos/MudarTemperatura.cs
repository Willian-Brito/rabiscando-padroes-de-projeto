namespace DesignPatterns.Comportamentais.Command.Comandos;

public class MudarTemperatura : ICommand
{
    private ArCondicionado ArCondicionado;
    public int TemperaturaAtual { get; private set; }
    public int TemperaturaAnterior { get; private set; }

    public MudarTemperatura(ArCondicionado arCondicionado)
    {
        ArCondicionado = arCondicionado;
        TemperaturaAtual = arCondicionado.Temperatura;
        TemperaturaAnterior = arCondicionado.Temperatura;
    }

    public void SetTemperatura(int novaTemperatura)
    {
        TemperaturaAnterior = TemperaturaAtual;
        TemperaturaAtual = novaTemperatura;
    }

    public void Desfazer()
    {
        ArCondicionado.SetTemperatura(TemperaturaAnterior);
        ArCondicionado.ImprimirObjeto();
    }

    public void Executar()
    {
        ArCondicionado.SetTemperatura(TemperaturaAtual);
        ArCondicionado.ImprimirObjeto();
    }
}