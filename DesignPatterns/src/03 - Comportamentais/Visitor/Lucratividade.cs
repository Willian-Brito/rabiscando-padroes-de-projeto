namespace DesignPatterns.Comportamentais.Visitor;

public class Lucratividade : IVisitor
{
    public decimal VisitSupermercado(Supermercado supermercado)
    {
        var lucratividade = 0M;

        supermercado.Departamentos.ForEach(departamento => 
        {
            lucratividade += departamento.Produtos.Sum(produto => CalcularLucratividade(produto));
        });
        
        return lucratividade;
    }

    public decimal VisitDepartamento(Departamento departamento)
    {
        return departamento.Produtos.Sum(produto => CalcularLucratividade(produto));
    }

    public decimal VisitProduto(Produto produto)
    {
        return CalcularLucratividade(produto);
    }

    private decimal CalcularLucratividade(Produto produto)
    {
        return (produto.Preco * produto.MargemLucro) / 100;
    }
}