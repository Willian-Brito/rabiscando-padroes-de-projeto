namespace DesignPatterns.Comportamentais.Mediator;

public abstract class Usuario
{
    protected ISalaDeChatMediator Mediator { get; set; } = null;
    protected string Nome { get; set; }

    public Usuario(string nome)
    {        
        Nome = nome;
    }

    public void SetMediator(ISalaDeChatMediator mediator)
    {
        if(Mediator != null)
            Mediator.RemoverUsuario(this);        

        Mediator = mediator;
        Mediator.AdicionarUsuario(this);
    }
    
    public abstract void Enviar(string mensagem);
    public abstract void Receber(string mensagem);
}