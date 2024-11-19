namespace DesignPatterns.Estruturais.Decorator;

public class MassaIntegral : AcrescimoDecorator
{
    public MassaIntegral(Pizza pizza) : base(pizza)
    {
    }

    public override string GetDescricao()
    {
        return $"{Pizza.GetDescricao()} + Massa Integral";
    }

    public override decimal GetPreco()
    {
        return Pizza.GetPreco() + 5;
    }
}