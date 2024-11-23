namespace DesignPatterns.Comportamentais.Command;

public class ArCondicionado
{
    public string ID { get; private set; }
    public bool Estado { get; private set; }
    public int Temperatura { get; private set; }

    public ArCondicionado(string id, bool estado, int temperatura)
    {
        ID = id;
        Estado = estado;
        Temperatura = temperatura;
    }

    public void Ligar()
    {
        Estado = true;
    }

    public void Desligar()
    {
        Estado = false;
    }

    public void SetTemperatura(int temperatura)
    {
        Temperatura = temperatura;
    }

    public void ImprimirObjeto()
    {
        var parte1 = Estado ? "Ligado" : "Desligado";
        var parte2 = Estado ? $"a {Temperatura} graus celsius" : "";
        var resultado = $"O Objeto {ID} está {parte1} {parte2}\n";

        Console.WriteLine(resultado);
    }
}