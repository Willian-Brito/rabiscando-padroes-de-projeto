namespace DesignPatterns.Estruturais.Composite;

public class Pasta : Component
{
    public List<Component> Componentes { get; set; }

    public Pasta(string nome, string caminho) : base(nome, caminho) 
    {
        Componentes = new List<Component>();
    }

    public override void Adicionar(Component componente)
    {
        Componentes.Add(componente);
    }

    public override void Remover(Component componente)
    {
        Componentes.Remove(componente);
    }

    public override Component RecuperarFilho(int indice)
    {
        return Componentes.ElementAt(indice);
    }

    public override void Exibir(int nivel = 0)
    {        
        Console.WriteLine($"{new string(' ', nivel + 2)}📁 {Nome} [{Caminho}]");        

        foreach (var componente in Componentes)
        {
            componente.Exibir(nivel + 2);        
        }
    }
}