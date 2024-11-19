namespace DesignPatterns.Estruturais.Decorator;

public class PizzaCalabreza : Pizza
{
    public PizzaCalabreza()
    {
        Descricao = "Deliciosa pizza de calabreza" ;
    }

    public override string GetDescricao()
    {
        return Descricao;
    }

    public override decimal GetPreco()
    {
        return 25;
    }
}