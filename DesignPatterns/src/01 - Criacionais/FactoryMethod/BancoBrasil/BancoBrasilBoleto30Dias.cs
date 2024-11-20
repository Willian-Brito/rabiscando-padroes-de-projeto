namespace DesignPatterns.Criacionais.FactoryMethod.BancoBrasil;

public class BancoBrasilBoleto30Dias : Abstract.Boleto
{
    public BancoBrasilBoleto30Dias(decimal valor) : base(valor)
    {
        Juros = 0.05M;
        Desconto = 0.02M;
        Multa = 0.05M;
    }
}