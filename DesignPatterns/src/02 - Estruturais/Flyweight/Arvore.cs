namespace DesignPatterns.Estruturais.Flyweght;

public class Arvore
{
    private int X;
    private int Y;    
    private EspecieFlyweight Flyweight;    

    public Arvore(int x, int y, EspecieFlyweight flyweight)
    {
        X = x;
        Y = y;
        Flyweight = flyweight;
    }

    public List<Arvore> RetornaArvore()
    {
        var arvores = new List<Arvore>();
        arvores.Add(this);

        return arvores;
    }

    public string ToString()
    {
        var json = $"{{ \"X\": \"{X}\", \"Y\": \"{Y}\", \"Especie\": {{ \"Nome\": \"{Flyweight.Nome}\", \"Cor\": \"{Flyweight.Cor}\", \"AlturaMaxima\": \"{Flyweight.AlturaMaxima}\" }} }}";
        return json;
    }
}