namespace DesignPatterns.Estruturais.Decorator;

public class Decorator
{
    public static void Executar()
    {
        var pizzaQueijo = new PizzaQueijo();

        Console.WriteLine($"\nDescrição: {pizzaQueijo.GetDescricao()}");
        Console.WriteLine($"\nPreço: R$ {pizzaQueijo.GetPreco()}");

        var pizzaQueijoBordaRequeijao = new BordaRequeijao(pizzaQueijo); 

        Console.WriteLine($"\n\nDescrição: {pizzaQueijoBordaRequeijao.GetDescricao()}");
        Console.WriteLine($"\nPreço: R$ {pizzaQueijoBordaRequeijao.GetPreco()}");

        var pizzaQueijoBordaRequeijaoMassaIntegral = new MassaIntegral(pizzaQueijoBordaRequeijao); 

        Console.WriteLine($"\n\nDescrição: {pizzaQueijoBordaRequeijaoMassaIntegral.GetDescricao()}");
        Console.WriteLine($"\nPreço: R$ {pizzaQueijoBordaRequeijaoMassaIntegral.GetPreco()}");
    }
}