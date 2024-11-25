namespace DesignPatterns.Comportamentais.Mediator;

public class ChatBot : Usuario
{
    private Usuario UltimoUsuario;

    public ChatBot(string nome = null) : base(nome) 
    { 
        Nome = "CHATBOT";
        UltimoUsuario = this;
    }

    public override void Enviar(string mensagem)
    {        
        Console.WriteLine($"## {Nome} enviou {mensagem} ##");
        Console.WriteLine("---------");

        Mediator.EnviarMensagem(mensagem, this);
    }

    public override void Receber(string mensagem)
    {
        Console.WriteLine($"{Nome} recebeu {mensagem}");
    }

    public bool ValidarMensagem(Usuario usuario)
    {
        if(UltimoUsuario == usuario)
        {
            Enviar($"Uma mensagem de {Nome} foi negada");
            return false;
        }

        UltimoUsuario = usuario;
        return true;
    }
}