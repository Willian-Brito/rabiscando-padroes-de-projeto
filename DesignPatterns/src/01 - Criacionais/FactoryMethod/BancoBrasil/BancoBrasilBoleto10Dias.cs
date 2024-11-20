namespace DesignPatterns.Criacionais.FactoryMethod.BancoBrasil;

public class BancoBrasilBoleto10Dias : Abstract.Boleto
{
    public BancoBrasilBoleto10Dias(decimal valor) : base(valor)
    {
        Juros = 0.03M;
        Desconto = 0.05M;
        Multa = 0.02M;
    }
}