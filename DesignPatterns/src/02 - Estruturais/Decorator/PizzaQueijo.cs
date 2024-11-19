namespace DesignPatterns.Estruturais.Decorator;

public class PizzaQueijo : Pizza
{
    public PizzaQueijo()
    {
        Descricao = "Deliciosa pizza de queijo" ;
    }

    public override string GetDescricao()
    {
        return Descricao;
    }

    public override decimal GetPreco()
    {
        return 22;
    }
}