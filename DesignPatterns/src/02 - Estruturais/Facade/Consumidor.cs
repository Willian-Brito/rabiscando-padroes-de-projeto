namespace DesignPatterns.Estruturais.Facade;

public class Consumidor
{
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public string Email { get; private set; }

    public Consumidor(string nome, string cpf, string email)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;        
    }
}