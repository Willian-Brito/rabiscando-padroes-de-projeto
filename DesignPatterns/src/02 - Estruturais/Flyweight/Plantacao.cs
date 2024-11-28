namespace DesignPatterns.Estruturais.Flyweght;

public class Plantacao
{
    private List<Arvore> Arvores = new List<Arvore>(); 
    private EspecieFabrica EspecieFabrica = new EspecieFabrica(); 

    public void AddArvore(int x, int y, string nome, string cor, decimal alturaMaxima)
    {
        var especie = EspecieFabrica.GetEspecie(nome, cor, alturaMaxima);
        var arvore = new Arvore(x, y, especie);
        Arvores.Add(arvore);
    }

    public List<List<Arvore>> RetornaArvores()
    {
        var arvores = new List<List<Arvore>>();
        Arvores.ForEach(arvore => arvores.Add(arvore.RetornaArvore()));

        return arvores;
    }

    public List<List<EspecieFlyweight>> RetornaEspecies()
    {
        var especies = EspecieFabrica.RetornaTodasEspecies();
        var especiesArray = new List<List<EspecieFlyweight>>();

        especies.ForEach(especie => especiesArray.Add(especie.RetornaEspecie()));

        return especiesArray;
    }
}