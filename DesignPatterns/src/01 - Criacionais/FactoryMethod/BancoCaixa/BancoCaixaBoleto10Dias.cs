namespace DesignPatterns.Criacionais.FactoryMethod.BancoCaixa;

public class BancoCaixaBoleto10Dias : Abstract.Boleto
{
    public BancoCaixaBoleto10Dias(decimal valor) : base(valor)
    {
        Juros = 0.02M;
        Desconto = 0.1M;
        Multa = 0.05M;
    }
}