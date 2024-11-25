namespace DesignPatterns.Comportamentais.Mediator;

public abstract class ISalaDeChatMediator
{
    protected ChatBot ChatBot { get; set; }
    protected string Nome { get; set; }

    public ISalaDeChatMediator(ChatBot chatBot, string nome)
    {
        ChatBot = chatBot;
        Nome = nome;
    }

    public abstract void EnviarMensagem(string mensagem, Usuario usuario);
    public abstract void AdicionarUsuario(Usuario usuario);
    public abstract void RemoverUsuario(Usuario usuario);
    public abstract string GetNome();
}