namespace DesignPatterns.Comportamentais.Observer;

public class Email 
{
    public static void Enviar(IObserver observer, string mensagem)
    {
        Console.WriteLine($"\nEmail enviado {observer.GetNome()} - {observer.GetEmail()}");
        Console.WriteLine($"\nMensagem: {mensagem}");
        Console.WriteLine("\n--------------------------------------");
    }
}