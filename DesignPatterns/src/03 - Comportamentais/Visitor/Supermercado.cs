namespace DesignPatterns.Comportamentais.Visitor;

public class Supermercado : IElemento
{
    public string Nome { get; set; }
    public List<Departamento> Departamentos { get; set; }

    public Supermercado(string nome)
    {
        Nome = nome;
        Departamentos = new List<Departamento>();
    }

    public void AddDepartamento(Departamento departamento)
    {
        Departamentos.Add(departamento);
    }

    public decimal Aceitar(IVisitor visitor)
    {
        return visitor.VisitSupermercado(this);
    }
}