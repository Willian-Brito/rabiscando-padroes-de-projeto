namespace DesignPatterns.Estruturais.Bridge;

public class MensagemUsuario : Mensagem
{
    public MensagemUsuario(ICanalDeEnvio canalDeEnvio) : base(canalDeEnvio) { }

    public override void Enviar()
    {
        Console.WriteLine("Mensagem enviada pelo USUÁRIO");
        Canal.Enviar(Assunto, Mensagens);
    }
}