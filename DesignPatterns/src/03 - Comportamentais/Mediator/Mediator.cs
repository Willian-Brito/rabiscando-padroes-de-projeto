namespace DesignPatterns.Comportamentais.Mediator;

public class Mediator
{
    public static void Executar()
    {
        var chatBot1 = new ChatBot();
        var salaDeChat1 = new SalaDeChatMediator(chatBot1, "Sala de chat 1");

        var chatBot2 = new ChatBot();
        var salaDeChat2 = new SalaDeChatMediator(chatBot2, "Sala de chat 2");

        var joao = new Humano("João");
        var maria = new Humano("Maria");
        var paulo = new Humano("Paulo");
        var lucia = new Humano("Lucia");
        var pedro = new Humano("Pedro");

        joao.SetMediator(salaDeChat1);
        maria.SetMediator(salaDeChat1);
        paulo.SetMediator(salaDeChat1);

        lucia.SetMediator(salaDeChat2);
        pedro.SetMediator(salaDeChat2);

        Console.WriteLine("[Sala 1] João envia sua primeira mensagem");
        joao.Enviar("Olá pessoal da sala 1, td bem ?");

        Console.WriteLine("\n\n[Sala 2] Lucia envia sua primeira mensagem");
        lucia.Enviar("Olá Pedro, td bem ?");

        Console.WriteLine("\n\n[Sala 1] Paulo respondeu a João");
        paulo.Enviar("Tudo bem comigo!");

        Console.WriteLine("\n\n[Sala 1] Paulo tenta enviar duas mensagens consecutivas");
        paulo.Enviar("E com vocês?");

        Console.WriteLine("\n\nLucia troca de sala");
        lucia.SetMediator(salaDeChat1);

        Console.WriteLine("\n\n[Sala 2] Lucia envia sua primeira mensagem");
        lucia.Enviar("Olá pessoal da sala 1, sou Lucia, td bem ?");

        Console.WriteLine("\n\n[Sala 2] Lucia envia sua primeira mensagem");
        lucia.Enviar("Olá pessoal da sala 1, sou Lucia, td bem ?");
    }
}