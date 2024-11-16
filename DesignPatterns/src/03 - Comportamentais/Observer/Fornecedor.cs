namespace DesignPatterns.Comportamentais.Observer;

public class Fornecedor : IObserver
{
    private string Nome { get; set; }
    private string Email { get; set; }
    private ISubject Subject { get; set; }

    public Fornecedor(string nome, string email, ISubject subject)
    {
        Nome = nome;
        Email = email;        
        Subject = subject;
        Subject.Register(this);
    }

    public void Update(string mensagem)
    {
        Comportamentais.Observer.Email.Enviar(this, mensagem);
    }

    public string GetNome()
    {
        return Nome;
    }

    public string GetEmail()
    {
        return Email;
    }
}
