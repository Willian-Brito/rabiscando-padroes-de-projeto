namespace DesignPatterns.Comportamentais.TemplateMethod;

public class TemplatMethod
{
    public static void Executar()
    {
        var valor = 1000M;
        var gateway = new Gateway();

        Console.WriteLine("\n- Credito");
        var pagamentoCredito = new PagamentoCredito(valor, gateway);
        pagamentoCredito.Cobrar();

        Console.WriteLine("\n\n- Debito");
        var pagamentoDebito = new PagamentoDebito(valor, gateway);
        pagamentoDebito.Cobrar();

        Console.WriteLine("\n\n- Dinheiro");
        var pagamentoDinheiro = new PagamentoDinheiro(valor, gateway);
        pagamentoDinheiro.Cobrar();
    }
}
