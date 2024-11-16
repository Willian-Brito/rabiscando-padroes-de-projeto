namespace DesignPatterns.Comportamentais.Observer;

public class Observer
{
    public static void Executar()
    {
        var newsletter = new Newsletter();
        var funcionario1 = new Funcionario("Funcionario 1", "funcionario1@aiko.digital", newsletter);
        var funcionario2 = new Funcionario("Funcionario 2", "funcionario2@aiko.digital", newsletter);
        
        var cliente = new Cliente("Cliente 1", "cliente1@aiko.digital", newsletter);
        var parceiro = new Parceiro("Parceiro 1", "parceiro1@aiko.digital", newsletter);
        var fornecedor = new Fornecedor("Fornecedor 1", "fornecedor1@aiko.digital", newsletter);

        newsletter.AddMensagem("Primeira Mensagem!");

        newsletter.Remove(funcionario2);

        Console.WriteLine("\n#######");

        newsletter.AddMensagem("Segunda Mensagem!");

        newsletter.Remove(parceiro);

        Console.WriteLine("\n#######");

        newsletter.AddMensagem("Terceira Mensagem!");

        newsletter.Register(funcionario2);

        Console.WriteLine("\n#######");

        newsletter.AddMensagem("Quarta Mensagem!");

        Console.WriteLine("\n#######");

        newsletter.NotifyAll();
    }
}
