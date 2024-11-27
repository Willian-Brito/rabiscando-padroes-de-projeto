namespace DesignPatterns.Criacionais.Prototype;

public class GerenciadorDePrototipos
{
    private Dictionary<string, IPrototype> Prototipos;

    public GerenciadorDePrototipos()
    {
        Prototipos = new Dictionary<string, IPrototype>();

        var livro = new Livro();
        livro.Nome = "Desconhecido";
        livro.Autor = "Desconhecido";
        livro.NumeroPaginas = 0;

        Prototipos.Add("livro", livro);

        var revista = new Revista();
        revista.Nome = "Desconhecido";
        revista.Edicao = "Desconhecido";        

        Prototipos.Add("revista", revista);

        var trabalho = new Trabalho();
        trabalho.Nome = "Desconhecido";
        trabalho.Autor = "Desconhecido";        
        trabalho.Tipo = "Desconhecido";        

        Prototipos.Add("trabalho", trabalho);
    }

    public IPrototype GetInstance(string identificador)
    {
        return Prototipos[identificador];
    }
}