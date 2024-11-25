namespace DesignPatterns.Comportamentais.Mediator;

public class Humano : Usuario
{
    public Humano(string nome) : base(nome) { }

    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"\n========= {Mediator.GetNome()} =========");
        Console.WriteLine($"\n{Nome} enviou: {mensagem}");
        Console.WriteLine("---------");

        Mediator.EnviarMensagem(mensagem, this);
    }

    public override void Receber(string mensagem)
    {
        Console.WriteLine($"{Nome} recebeu: {mensagem}");
    }
}