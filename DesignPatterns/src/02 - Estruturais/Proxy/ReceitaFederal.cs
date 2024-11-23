namespace DesignPatterns.Estruturais.Proxy;

public abstract class ReceitaFederal
{
    protected string Cpf { get; set; }

    public ReceitaFederal(string cpf)
    {
        Cpf = cpf;
    }
    public abstract string GetNome();
    public abstract int GetIdade();
    public abstract bool GetCpfAtivo();
}