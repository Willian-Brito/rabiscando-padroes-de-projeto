namespace DesignPatterns.Estruturais.Flyweght;

public class EspecieFabrica
{
    private List<EspecieFlyweight> Especies;

    public EspecieFabrica()
    {
        Especies = new List<EspecieFlyweight>();
    }

    public EspecieFlyweight GetEspecie(string nome, string cor, decimal alturaMaxima)
    {
        var especie = Especies.FirstOrDefault(e => e.Nome == nome && e.Cor == cor && e.AlturaMaxima == alturaMaxima);

        if(especie == null)
        {
            var novaEspecie = new EspecieFlyweight(nome, cor, alturaMaxima);
            Especies.Add(novaEspecie);

            return novaEspecie;
        }

        return especie;
    }

    public List<EspecieFlyweight> RetornaTodasEspecies()
    {
        return Especies;
    }
}