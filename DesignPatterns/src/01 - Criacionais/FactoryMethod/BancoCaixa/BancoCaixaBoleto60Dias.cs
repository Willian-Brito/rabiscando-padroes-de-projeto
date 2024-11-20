namespace DesignPatterns.Criacionais.FactoryMethod.BancoCaixa;

public class BancoCaixaBoleto60Dias : Abstract.Boleto
{
    public BancoCaixaBoleto60Dias(decimal valor) : base(valor)
    {
        Juros = 0.1M;
        Desconto = 0M;
        Multa = 0.2M;
    }
}