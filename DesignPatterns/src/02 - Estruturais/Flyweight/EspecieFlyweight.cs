namespace DesignPatterns.Estruturais.Flyweght;

public class EspecieFlyweight
{
    public string Nome {get; private set;}
    public string Cor {get; private set;}
    public decimal AlturaMaxima {get; private set;}

    public EspecieFlyweight(string nome, string cor, decimal alturaMaxima)
    {
        Nome = nome;
        Cor = cor;
        AlturaMaxima = alturaMaxima;
    }

    public List<EspecieFlyweight> RetornaEspecie()
    {
        var especies = new List<EspecieFlyweight>();
        especies.Add(this);

        return especies;
    }

    public string ToString()
    {
        var json = $"{{ \"Nome\": \"{Nome}\", \"Cor\": \"{Cor}\", \"AlturaMaxima\": \"{AlturaMaxima}\" }}";
        return json;
    }
}