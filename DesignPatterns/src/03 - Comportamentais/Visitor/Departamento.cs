namespace DesignPatterns.Comportamentais.Visitor;

public class Departamento : IElemento
{
    public string Nome { get; set; }
    public List<Produto> Produtos { get; set; }

    public Departamento(string nome)
    {
        Nome = nome;
        Produtos = new List<Produto>();
    }

    public void AddProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public decimal Aceitar(IVisitor visitor)
    {
        return visitor.VisitDepartamento(this);
    }
}