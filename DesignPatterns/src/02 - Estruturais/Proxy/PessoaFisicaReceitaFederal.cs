namespace DesignPatterns.Estruturais.Proxy;

public class PessoaFisicaReceitaFederal : ReceitaFederal
{
    private string Nome;    
    private int Idade;
    private bool CpfAtivo;

    public PessoaFisicaReceitaFederal(string cpf) : base(cpf)
    {        
        Nome = "João da Silva";
        Idade = 25;
        CpfAtivo = true;

        Thread.Sleep(5000);
        Console.WriteLine("Pessoa FisicaReceitaFederal criada com sucesso");
    }

    public override string GetNome()
    {
        Thread.Sleep(2000);
        return Nome;
    }

    public override int GetIdade()
    {
        Thread.Sleep(2000);
        return Idade;
    }

    public override bool GetCpfAtivo()
    {
        Thread.Sleep(3000);
        return CpfAtivo;
    }
}