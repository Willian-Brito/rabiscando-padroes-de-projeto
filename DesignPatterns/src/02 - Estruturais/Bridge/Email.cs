namespace DesignPatterns.Estruturais.Bridge;

public class Email : ICanalDeEnvio
{
    public void Enviar(string assunto, string mensagem)
    {
        Console.WriteLine("=== Mensagem enviada E-MAIL ===");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Mensagem: {mensagem}\n");
        Console.WriteLine("-----------");
    }
}