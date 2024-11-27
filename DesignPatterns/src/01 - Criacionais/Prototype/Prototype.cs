namespace DesignPatterns.Criacionais.Prototype;

public class Prototype
{
    public static void Executar()
    {
        var gerenciadorProdotipos = new GerenciadorDePrototipos();

        var livroPrototipo = gerenciadorProdotipos.GetInstance("livro");
        var livro1 = (Livro)livroPrototipo.Clone();

        Console.WriteLine("==== Livro 1 ====");

        Console.WriteLine("\n\n==== Livro 1 com valores padrão ====");
        Console.WriteLine(livro1.ToString());

        livro1.Nome = "Livro 1";
        livro1.Autor = "Lucas da Silva";
        livro1.NumeroPaginas = 325;

        Console.WriteLine("\n\n==== Livro 1 com valores editados ====");
        Console.WriteLine(livro1.ToString());

        var livro2 = (Livro)livroPrototipo.Clone();   

        Console.WriteLine("\n\n==== Livro 2 com valores padrão ====");
        Console.WriteLine(livro2.ToString());   

        livro2.Nome = "Livro 2";
        livro2.Autor = "Marlene dos Santos";
        livro2.NumeroPaginas = 420;

        Console.WriteLine("\n==== Livro 1 e 2 com valores editados ====");
        Console.WriteLine(livro1.ToString());
        Console.WriteLine(livro2.ToString());
    }
}