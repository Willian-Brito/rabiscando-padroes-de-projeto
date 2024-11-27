namespace DesignPatterns.Criacionais.Prototype;

public class Livro : IPrototype
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public IPrototype Clone()
    {
        var clone = new Livro();
        clone.Nome = Nome;
        clone.Autor = Autor;
        clone.NumeroPaginas = NumeroPaginas;

        return clone;
    }

    public string ToString()
    {
        var json = $"{{ \"Nome\": \"{Nome}\", \"Autor\": \"{Autor}\", \"NumeroPaginas\": \"{NumeroPaginas}\" }}";
        return json;
    }
}