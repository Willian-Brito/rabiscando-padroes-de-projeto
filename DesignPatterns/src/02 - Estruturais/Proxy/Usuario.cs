namespace DesignPatterns.Estruturais.Proxy;

public class Usuario
{
    public string Nome {get; private set;}
    public string Cpf {get; private set;}
    public int Idade {get; private set;}
    private ReceitaFederal PessoaFisica;

    public Usuario(string nome, string cpf, int idade)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        PessoaFisica = new PessoaFisicaReceitaFederalProxy(cpf);
    }

    public bool ValidarNome()
    {
        return Nome == PessoaFisica.GetNome();
    }

    public bool VerificarCpfAtivo()
    {    
        return PessoaFisica.GetCpfAtivo();
    }

    public bool VerificarMaiorIdade()
    {        
        return Idade >= 18 && Idade == PessoaFisica.GetIdade();
    }
}