namespace DesignPatterns.Estruturais.Proxy;

public class PessoaFisicaReceitaFederalProxy : ReceitaFederal
{
    private ReceitaFederal PessoaFisicaRF = null;

    public PessoaFisicaReceitaFederalProxy(string cpf) : base(cpf) { }

    private void CriarPessoaFisicaReceitaFederal()
    {
        if(PessoaFisicaRF is null) 
            PessoaFisicaRF = new PessoaFisicaReceitaFederal(Cpf);
    }

    public override string GetNome()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRF.GetNome();
    }

    public override int GetIdade()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRF.GetIdade();
    }

    public override bool GetCpfAtivo()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRF.GetCpfAtivo();
    }
}