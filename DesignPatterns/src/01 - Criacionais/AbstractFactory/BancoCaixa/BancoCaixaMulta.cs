using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoCaixa;

public class BancoCaixaMulta : IMulta
{
    public decimal GetMulta()
    {
        return 0.05M;
    }
}