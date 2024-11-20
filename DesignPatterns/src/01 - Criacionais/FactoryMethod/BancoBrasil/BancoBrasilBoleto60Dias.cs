namespace DesignPatterns.Criacionais.FactoryMethod.BancoBrasil;

public class BancoBrasilBoleto60Dias : Abstract.Boleto
{
    public BancoBrasilBoleto60Dias(decimal valor) : base(valor)
    {
        Juros = 0.1M;
        Desconto = 0M;
        Multa = 0.15M;
    }
}