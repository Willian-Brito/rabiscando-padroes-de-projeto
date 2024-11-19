namespace DesignPatterns.Estruturais.Adapter.Terceiros;

public class TopPagamentos 
{
    private decimal Valor;
    private int Parcelas;
    private string NumeroCartao;
    private string Cvv;

    public void SetValor(decimal valor)
    {
        Valor = valor;
    }

    public void SetQuantidadeParcelas(int parcelas)
    {
        Parcelas = parcelas;
    }

    public void SetCartao(string numeroCartao, string cvv)
    {
        NumeroCartao = numeroCartao;
        Cvv = cvv;
    }

    public bool Pagar()
    {
        Console.Write("Pagamento realizado via TopPagamentos");
        return true;
    }   
}