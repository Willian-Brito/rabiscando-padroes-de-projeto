namespace DesignPatterns.Comportamentais.Mediator;

public class SalaDeChatMediator : ISalaDeChatMediator
{
    private List<Usuario> Usuarios;    

    public SalaDeChatMediator(ChatBot chatBot, string nome) : base(chatBot, nome) 
    { 
        Usuarios = new List<Usuario>();
        ChatBot.SetMediator(this);
    }

    public override void EnviarMensagem(string mensagem, Usuario usuario)
    {
        if(ChatBot.ValidarMensagem(usuario))
        {
            Usuarios.ForEach(u => {
                if(u != usuario)
                    u.Receber(mensagem);
            });            
        }
    }

    public override void AdicionarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }

    public override void RemoverUsuario(Usuario usuario)
    {
        Usuarios.Remove(usuario);
    }

    public override string GetNome()
    {
        return Nome;
    }
}