namespace DesignPatterns.Comportamentais.TemplateMethod;

public class PagamentoDebito : Pagamento
{
    public PagamentoDebito(decimal valor, Gateway gateway) 
        : base(valor, gateway) { }

    public override decimal CalcularTaxa()
    {
        return 4;
    }

    public override decimal CalcularDesconto()
    {
        return Valor * 0.05M;;
    }
}
