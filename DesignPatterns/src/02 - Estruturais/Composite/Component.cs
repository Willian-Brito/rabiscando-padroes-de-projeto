namespace DesignPatterns.Estruturais.Composite;

public abstract class Component
{
    protected string Nome { get; set; }
    protected string Caminho { get; set; }

    public Component(string nome, string caminho)
    {   
        Nome = nome;
        Caminho = caminho; 
    }

    public virtual void Adicionar(Component componente)
    {
        throw new NotImplementedException("Operação não suportada!");
    }

    public virtual void Remover(Component componente)
    {
        throw new NotImplementedException("Operação não suportada!");
    }

    public virtual Component RecuperarFilho(int indice)
    {        
        throw new NotImplementedException("Operação não suportada!");
    }

    public virtual void Exibir(int nivel = 0)
    {
        throw new NotImplementedException("Operação não suportada!");
    }
}