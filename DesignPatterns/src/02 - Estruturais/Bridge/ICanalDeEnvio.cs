namespace DesignPatterns.Estruturais.Bridge;

public interface ICanalDeEnvio
{
    void Enviar(string assunto, string mensagem);
}