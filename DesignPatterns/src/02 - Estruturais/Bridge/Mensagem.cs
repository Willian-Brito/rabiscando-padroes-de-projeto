namespace DesignPatterns.Estruturais.Bridge;

public abstract class Mensagem
{
    protected string Assunto { get; set; }
    protected string Mensagens { get; set; }
    protected ICanalDeEnvio Canal { get; set; }

    public Mensagem(ICanalDeEnvio canalDeEnvio)
    {
        Canal = canalDeEnvio;
    }

    public abstract void Enviar();

    public void SetAssunto(string assunto)
    {
        Assunto = assunto;
    }   

    public void SetMensagem(string mensagem)
    {
        Mensagens = mensagem;
    }
}