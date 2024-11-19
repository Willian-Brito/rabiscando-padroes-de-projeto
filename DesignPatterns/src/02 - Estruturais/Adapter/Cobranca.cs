using DesignPatterns.Estruturais.Adapter.Terceiros;

namespace DesignPatterns.Estruturais.Adapter;

public class Cobranca
{
    private PagFacil Gateway {get; set;}

    public Cobranca(PagFacil gateway)
    {
        Gateway = gateway;
    }

    public void setGateway(PagFacil gateway)
    {
        Gateway = gateway;
    }

    public void setGateway(PagFacil gateway)
    {
        Gateway = gateway;
    }
}