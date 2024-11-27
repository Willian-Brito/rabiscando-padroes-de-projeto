namespace DesignPatterns.Criacionais.Prototype;

public class Trabalho : IPrototype
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Tipo { get; set; }

    public string ToString()
    {
        var json = $"{{ \"Nome\": \"{Nome}\", \"Autor\": \"{Autor}\", \"Tipo\": \"{Tipo}\" }}";
        return json;
    }

    public IPrototype Clone()
    {
        var clone = new Trabalho();
        clone.Nome = Nome;
        clone.Autor = Autor;
        clone.Tipo = Tipo;

        return clone;
    }
}