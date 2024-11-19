namespace DesignPatterns.Estruturais.Decorator;

public class BordaRequeijao : AcrescimoDecorator
{
    public BordaRequeijao(Pizza pizza) : base(pizza)
    {
    }

    public override string GetDescricao()
    {
        return $"{Pizza.GetDescricao()} + Borda Recheada de requeijão";
    }

    public override decimal GetPreco()
    {
        return Pizza.GetPreco() + 8.50M;
    }
}