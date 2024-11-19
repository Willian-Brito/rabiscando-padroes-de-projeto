namespace DesignPatterns.Estruturais.Decorator;

public class PizzaFrango : Pizza
{
    public PizzaFrango()
    {
        Descricao = "Deliciosa pizza de frango" ;
    }

    public override string GetDescricao()
    {
        return Descricao;
    }

    public override decimal GetPreco()
    {
        return 19;
    }
}