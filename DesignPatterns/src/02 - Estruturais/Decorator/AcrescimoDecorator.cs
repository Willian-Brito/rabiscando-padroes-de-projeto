namespace DesignPatterns.Estruturais.Decorator;

public abstract class AcrescimoDecorator : Pizza
{
    protected Pizza Pizza { get; set; }

    public AcrescimoDecorator(Pizza pizza)
    {
        Pizza = pizza;
    }

    abstract public override string GetDescricao();
    
    public abstract override decimal GetPreco();
}