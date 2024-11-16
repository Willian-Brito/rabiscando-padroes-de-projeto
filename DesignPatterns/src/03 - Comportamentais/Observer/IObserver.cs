namespace DesignPatterns.Comportamentais.Observer;

public interface IObserver
{
    void Update(string mensagem);
    string GetNome();
    string GetEmail();
}
