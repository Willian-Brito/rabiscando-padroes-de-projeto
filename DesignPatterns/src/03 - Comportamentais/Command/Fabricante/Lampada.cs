namespace DesignPatterns.Comportamentais.Command;

public class Lampada
{
    public string ID { get; private set; }
    public bool Estado { get; private set; }    

    public Lampada(string id, bool estado)
    {
        ID = id;
        Estado = estado;        
    }

    public void Ligar()
    {
        Estado = true;
    }

    public void Desligar()
    {
        Estado = false;
    }

    public void ImprimirObjeto()
    {
        var parte1 = Estado ? "Ligado" : "Desligado";        
        var resultado = $"O Objeto {ID} está {parte1}\n";
        
        Console.WriteLine(resultado);
    }
}