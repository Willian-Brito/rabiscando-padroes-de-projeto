namespace DesignPatterns.Estruturais.Composite;

public class Composite
{
    public static void Executar()
    {
        var raiz = new Pasta("Raiz", "/");
        var pasta1 = new Pasta("Pasta 1", "pasta1/");
        var pasta2 = new Pasta("Pasta 2", "pasta2/");
        var pasta2_1 = new Pasta("Pasta 2.1", "pasta2-1/");
        var pasta3 = new Pasta("Pasta 3", "pasta3/");

        raiz.Adicionar(pasta1);
        raiz.Adicionar(pasta2);
        raiz.Adicionar(pasta3);
        pasta2.Adicionar(pasta2_1);

        var arquivo1 = new Arquivo("Arquivo 1", "/arquivo1");
        var arquivo2 = new Arquivo("Arquivo 2", "/arquivo2");
        var arquivo3 = new Arquivo("Arquivo 3", "/arquivo3");
        var arquivo4 = new Arquivo("Arquivo 4", "/arquivo4");
        var arquivo5 = new Arquivo("Arquivo 5", "/arquivo5");
        var arquivo6 = new Arquivo("Arquivo 6", "/arquivo6");

        pasta1.Adicionar(arquivo1);
        pasta1.Adicionar(arquivo2);
        pasta2.Adicionar(arquivo3);
        pasta2.Adicionar(arquivo4);
        pasta2_1.Adicionar(arquivo5);
        pasta3.Adicionar(arquivo6);

        var gerenciador = new GerenciadorDeArquivos(raiz);
        gerenciador.ExibirTodos();
    }    
}