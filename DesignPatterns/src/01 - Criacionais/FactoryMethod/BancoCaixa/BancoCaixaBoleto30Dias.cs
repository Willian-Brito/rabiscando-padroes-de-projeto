namespace DesignPatterns.Criacionais.FactoryMethod.BancoCaixa;

public class BancoCaixaBoleto30Dias : Abstract.Boleto
{
    public BancoCaixaBoleto30Dias(decimal valor) : base(valor)
    {
        Juros = 0.05M;
        Desconto = 0.05M;
        Multa = 0.1M;
    }
}