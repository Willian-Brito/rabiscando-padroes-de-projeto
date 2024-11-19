namespace DesignPatterns.Estruturais.Adapter.Terceiros;

public class PagFacil 
{
    private decimal Valor;
    private int Parcelas;
    private string NumeroCartao;
    private string Cvv;

    public void SetValor(decimal valor)
    {
        Valor = valor;
    }

    public void SetParcelas(int parcelas)
    {
        Parcelas = parcelas;
    }

    public void SetNumeroCartao(string numeroCartao)
    {
        NumeroCartao = numeroCartao;
    }

    public void SetCVV(string cvv)
    {
        Cvv = cvv;
    }
    public bool ValidarCartao()
    {
        if( !string.IsNullOrWhiteSpace(NumeroCartao) &&
            !string.IsNullOrWhiteSpace(Cvv) &&
            Cvv.Length == 3
        )
            return true;

        return false;
    }

    public bool Pagar()
    {
        Console.Write("Pagamento realizado via PagFacil");
        return true;
    }
}