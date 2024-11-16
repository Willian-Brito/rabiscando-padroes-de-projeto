namespace DesignPatterns.Comportamentais.Observer;

public class Newsletter : ISubject
{
    public List<IObserver> Observers { get; set; } = new List<IObserver>();
    public List<string> Mensagens { get; set; } = new List<string>();

    public void NotifyAll()
    {
        var ultimaMensagem = Mensagens.LastOrDefault();
        Observers.ForEach(observer => observer.Update(ultimaMensagem));
    }

    public void Register(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void AddMensagem(string mensagem) 
    {
        Mensagens.Add(mensagem);
        NotifyAll();
    }
}
