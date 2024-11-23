namespace DesignPatterns.Comportamentais.Visitor;

public interface IVisitor
{
    decimal VisitSupermercado(Supermercado supermercado);
    decimal VisitDepartamento(Departamento departamento);
    decimal VisitProduto(Produto produto);
}

