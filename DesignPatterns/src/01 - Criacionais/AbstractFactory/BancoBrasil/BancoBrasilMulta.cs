using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoBrasil;

public class BancoBrasilMulta : IMulta
{
    public decimal GetMulta()
    {
        return 0.02M;
    }
}