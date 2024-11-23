namespace DesignPatterns.Estruturais.Bridge;

public class SMS : ICanalDeEnvio
{
    public void Enviar(string assunto, string mensagem)
    {
        Console.WriteLine("=== Mensagem enviada SMS ===");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Mensagem: {mensagem}\n");
        Console.WriteLine("-----------");
    }
}