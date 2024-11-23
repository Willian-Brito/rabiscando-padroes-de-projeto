namespace DesignPatterns.Estruturais.Bridge;

public class MensagemAdmin : Mensagem
{
    public MensagemAdmin(ICanalDeEnvio canalDeEnvio) : base(canalDeEnvio) { }

    public override void Enviar()
    {
        Console.WriteLine("Mensagem enviada pelo ADMINISTRADOR");
        Canal.Enviar(Assunto, Mensagens);
    }
}