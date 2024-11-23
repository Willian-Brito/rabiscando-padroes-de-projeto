namespace DesignPatterns.Estruturais.Bridge;

public class Bridge
{
    public static void Executar()
    {
        Mensagem mensagem;
        ICanalDeEnvio canalDeEnvio;
        
        #region Email
        canalDeEnvio = new Email();

        mensagem = new MensagemAdmin(canalDeEnvio);
        mensagem.SetAssunto("Primemira mensagem");
        mensagem.SetMensagem("Olá Usuário");
        mensagem.Enviar();

        mensagem = new MensagemUsuario(canalDeEnvio);
        mensagem.SetAssunto("Primemira mensagem");
        mensagem.SetMensagem("Olá Administrador");
        mensagem.Enviar();
        #endregion

        #region SMS
        canalDeEnvio = new SMS();

        mensagem = new MensagemAdmin(canalDeEnvio);
        mensagem.SetAssunto("Segunda mensagem");
        mensagem.SetMensagem("Olá Usuário");
        mensagem.Enviar();

        mensagem = new MensagemUsuario(canalDeEnvio);
        mensagem.SetAssunto("Segunda mensagem");
        mensagem.SetMensagem("Olá Administrador");
        mensagem.Enviar();
        #endregion
    }
}