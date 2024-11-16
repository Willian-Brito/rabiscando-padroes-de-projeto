namespace DesignPatterns.Comportamentais.TemplateMethod;

public class Gateway
{
    public bool Pagar(decimal valor)
    {
        var respostas = new bool[] {true, false};

        var random = new Random().NextDouble();        
        var result = (int)Math.Round(random);

        Console.Write($"R$ {valor}");
        return respostas[result];
    }
}