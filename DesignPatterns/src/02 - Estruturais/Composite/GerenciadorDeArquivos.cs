namespace DesignPatterns.Estruturais.Composite;

public class GerenciadorDeArquivos
{
    private Component Raiz;

    public GerenciadorDeArquivos(Component raiz)
    {
        Raiz = raiz;
    }

    public void ExibirTodos()
    {
        Raiz.Exibir();
    }
}