namespace DesignPatterns.Estruturais.Adapter;

public class Cobranca
{
    private IGatewayPagamentos Gateway {get; set;}

    public Cobranca(IGatewayPagamentos gateway)
    {
        Gateway = gateway;
    }

    public void SetGateway(IGatewayPagamentos gateway)
    {
        Gateway = gateway;
    }

    public void SetValor(decimal valor)
    {
        Gateway.SetValor(valor);
    }

    public void SetParcelas(int parcelas)
    {
        Gateway.SetParcelas(parcelas);
    }

    public void SetNumeroCartao(string numeroCartao)
    {
        Gateway.SetNumeroCartao(numeroCartao);
    }

    public void SetCVV(string cvv)
    {
        Gateway.SetCVV(cvv);
    }

    public bool ValidarCartao()
    {
        return Gateway.ValidarCartao();
    }

    public bool Pagar()
    {
        return Gateway.Pagar();
    }
}