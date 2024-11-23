namespace DesignPatterns.Comportamentais.Visitor;

public interface IElemento
{
    decimal Aceitar(IVisitor visitor);
}

