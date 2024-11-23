namespace DesignPatterns.Comportamentais.Visitor;

public class Produto : IElemento
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public decimal MargemLucro { get; set; }

    public Produto(string nome, decimal preco, decimal margemLucro)
    {
        Nome = nome;
        Preco = preco;
        MargemLucro = margemLucro;
    }

    public decimal Aceitar(IVisitor visitor)
    {
        return visitor.VisitProduto(this);
    }
}