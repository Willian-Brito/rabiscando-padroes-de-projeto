namespace DesignPatterns.Comportamentais.TemplateMethod;

public abstract class Pagamento
{
    protected decimal Valor { get; private set; }
    private Gateway Gateway { get; set; }

    public Pagamento(decimal valor, Gateway gateway)
    {
        Valor = valor;
        Gateway = gateway;
    }
    public abstract decimal CalcularDesconto();

    // Hook (Padrão para algumas sub classes)
    public virtual decimal CalcularTaxa()
    {
        return 0;
    }

    // Template Method
    public bool Cobrar()
    {
        var taxa = CalcularTaxa();
        var desconto = CalcularDesconto();
        var valorFinal = Valor + taxa - desconto;

        Console.Write($"\n{Valor} + {taxa} - {desconto} = ");
        return Gateway.Pagar(valorFinal);
    }
}
