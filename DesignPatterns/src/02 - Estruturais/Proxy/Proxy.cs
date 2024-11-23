using System.Diagnostics;

namespace DesignPatterns.Estruturais.Proxy;

public class Proxy
{
    public static void Executar()
    {
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var pessoaFisica = new Usuario("João da Silva", "12345678945", 25);
        Console.WriteLine(pessoaFisica.Idade);
        Console.WriteLine(pessoaFisica.VerificarMaiorIdade());

        stopwatch.Stop();

        Console.WriteLine($"# {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} segundos");
    }
}