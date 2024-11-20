using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoBrasil;

public class BancoBrasilDesconto : IDesconto
{
    public decimal GetDesconto()
    {
        return 0.05M;
    }
}