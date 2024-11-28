using DesignPatterns.Estruturais.Flyweght;

namespace DesignPatterns.Estruturais.Flyweight;

public class Flyweight
{
    public static void Executar()
    {
        var iteracao = 10;

        var plantacao = new Plantacao();
        var random = new Random();        

        for(var i = 0; i < iteracao; i++)
        {
            plantacao.AddArvore(random.Next(0, 501), random.Next(0, 501), "Ipê", "#2caf1e", 10);
            plantacao.AddArvore(random.Next(0, 501), random.Next(0, 501), "Palmeira", "#008a29", 7);
            plantacao.AddArvore(random.Next(0, 501), random.Next(0, 501), "Jabuticaba", "#00b626", 5);
        }

        Console.WriteLine("### Especies ###");
        plantacao.RetornaEspecies().ForEach(especies => 
        {
            especies.ForEach(especie => 
            {
                Console.WriteLine(especie.ToString());
            });
        });

        Console.WriteLine("\n\n### Árvores ###");
        plantacao.RetornaArvores().ForEach(arvores => 
        {
            arvores.ForEach(arvore => 
            {
                Console.WriteLine(arvore.ToString());
            });
        });
    }
}