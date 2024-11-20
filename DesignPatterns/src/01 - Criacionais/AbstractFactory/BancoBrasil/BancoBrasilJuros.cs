using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoBrasil;

public class BancoBrasilJuros : IJuros
{
    public decimal GetJuros()
    {
        return 0.03M;
    }
}