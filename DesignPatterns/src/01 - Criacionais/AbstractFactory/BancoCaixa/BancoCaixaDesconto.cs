using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoCaixa;

public class BancoCaixaDesconto : IDesconto
{
    public decimal GetDesconto()
    {
        return 0.1M;
    }
}