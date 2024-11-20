using DesignPatterns.Criacionais.FactoryMethod.Abstract;

namespace DesignPatterns.Criacionais.FactoryMethod.BancoCaixa;

public class BancoCaixa : Banco
{
    // Factory Method
    public override Boleto CriarBoleto(int vencimento, decimal valor)
    {
        switch (vencimento)
        {
            case 10:
                return new BancoCaixaBoleto10Dias(valor);                
            case 30:
                return new BancoCaixaBoleto30Dias(valor);                
            case 60:
                return new BancoCaixaBoleto60Dias(valor);
            default:
                throw new Exception("Vencimento indisponivel!");                
        }        
    }
}
