namespace DesignPatterns.Criacionais.Prototype;

public class Revista : IPrototype
{
    public string Nome { get; set; }
    public string Edicao { get; set; }

    public string ToString()
    {
        var json = $"{{ \"Nome\": \"{Nome}\", \"Edicao\": \"{Edicao}\" }}";
        return json;
    }

    public IPrototype Clone()
    {
        var clone = new Revista();
        clone.Nome = Nome;
        clone.Edicao = Edicao;        

        return clone;
    }
}