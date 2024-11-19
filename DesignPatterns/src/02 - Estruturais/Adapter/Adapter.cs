
using DesignPatterns.Estruturais.Adapter.Terceiros;

namespace DesignPatterns.Estruturais.Adapter;

public class Adapter
{
    public static void Executar()
    {
        //# LEGADO
        // var pagFacil = new PagFacil();
        // var cobranca = new Cobranca(pagFacil);

        var pagFacilAdapter = new PagFacilAdapter();
        var topPagamentos = new TopPagamentos();
        var topPagamentosAdapter = new TopPagamentosAdapter(topPagamentos);
        var cobranca = new Cobranca(pagFacilAdapter);        

        cobranca.SetValor(100);
        cobranca.SetParcelas(3);
        cobranca.SetNumeroCartao("123412341234");
        cobranca.SetCVV("123");

        if(cobranca.Pagar())
        {
            Console.WriteLine(" - sucesso\n");
        } 
        else 
        {
            Console.WriteLine(" - falha\n");
        }

        cobranca.SetGateway(topPagamentosAdapter);

        cobranca.SetValor(100);
        cobranca.SetParcelas(3);
        cobranca.SetNumeroCartao("123412341234");
        cobranca.SetCVV("123");

        if(cobranca.Pagar())
        {
            Console.WriteLine(" - sucesso\n");
        } 
        else 
        {
            Console.WriteLine(" - falha\n");
        }
    }
}