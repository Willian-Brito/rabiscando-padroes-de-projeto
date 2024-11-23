namespace DesignPatterns.Estruturais.Composite;

public class Arquivo : Component
{
    public Arquivo(string nome, string caminho) : base(nome, caminho) { }

    public override void Exibir(int nivel)
    {        
        Console.WriteLine($"{new string(' ', nivel + 2)}📄 {Nome} [{Caminho}]");
    }
}