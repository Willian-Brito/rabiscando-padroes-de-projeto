namespace DesignPatterns.Comportamentais.TemplateMethod;

public class PagamentoDinheiro : Pagamento
{
    public PagamentoDinheiro(decimal valor, Gateway gateway) 
        : base(valor, gateway) { }

    public override decimal CalcularDesconto()
    {
        return Valor * 0.1M;
    }
}
