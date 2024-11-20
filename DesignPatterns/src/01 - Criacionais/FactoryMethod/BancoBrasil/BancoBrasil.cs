using DesignPatterns.Criacionais.FactoryMethod.Abstract;

namespace DesignPatterns.Criacionais.FactoryMethod.BancoBrasil;

public class BancoBrasil : Banco
{
    // Factory Method
    public override Boleto CriarBoleto(int vencimento, decimal valor)
    {
        switch (vencimento)
        {
            case 10:
                return new BancoBrasilBoleto10Dias(valor);                
            case 30:
                return new BancoBrasilBoleto30Dias(valor);                
            case 60:
                return new BancoBrasilBoleto60Dias(valor);
            default:
                throw new Exception("Vencimento indisponivel!");                
        }        
    }
}
