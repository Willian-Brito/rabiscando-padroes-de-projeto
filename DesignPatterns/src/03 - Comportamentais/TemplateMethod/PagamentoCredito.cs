namespace DesignPatterns.Comportamentais.TemplateMethod;

public class PagamentoCredito : Pagamento
{
    public PagamentoCredito(decimal valor, Gateway gateway) 
        : base(valor, gateway) { }

    public override decimal CalcularTaxa()
    {
        return Valor * 0.05M;
    }

    public override decimal CalcularDesconto()
    {
        if(Valor > 300) return Valor * 0.02M;        
        return 0;
    }
}
