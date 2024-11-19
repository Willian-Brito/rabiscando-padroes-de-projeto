namespace DesignPatterns.Estruturais.Adapter;

public interface IGatewayPagamentos
{
    public void SetValor(decimal valor);
    public void SetParcelas(int parcelas);
    public void SetNumeroCartao(string numeroCartao);
    public void SetCVV(string cvv);
    public bool ValidarCartao();
    public bool Pagar();
}