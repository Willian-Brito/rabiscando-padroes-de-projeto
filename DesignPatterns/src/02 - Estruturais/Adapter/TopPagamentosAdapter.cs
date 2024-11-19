using DesignPatterns.Estruturais.Adapter.Terceiros;

namespace DesignPatterns.Estruturais.Adapter;

public class TopPagamentosAdapter : IGatewayPagamentos
{
    private TopPagamentos TopPagamentos {get; set;}
    private string? Cvv {get; set;} = null;
    private string? NumeroCartao {get; set;} = null;

    public TopPagamentosAdapter(TopPagamentos topPagamentos)
    {
        TopPagamentos = topPagamentos;
    }

    public bool Pagar()
    {
        return TopPagamentos.Pagar();
    }

    public void SetCVV(string cvv)
    {
        Cvv = cvv;

        if(!string.IsNullOrWhiteSpace(NumeroCartao))
            TopPagamentos.SetCartao(NumeroCartao, Cvv);
    }

    public void SetNumeroCartao(string numeroCartao)
    {
        NumeroCartao = numeroCartao;

        if(!string.IsNullOrWhiteSpace(Cvv))
            TopPagamentos.SetCartao(NumeroCartao, Cvv);
    }

    public void SetParcelas(int parcelas)
    {
        TopPagamentos.SetQuantidadeParcelas(parcelas);
    }

    public void SetValor(decimal valor)
    {
        TopPagamentos.SetValor(valor);
    }

    public bool ValidarCartao()
    {
        // retorna true, pois esse gateway valida ao processar pagamento
        return true;
    }
}