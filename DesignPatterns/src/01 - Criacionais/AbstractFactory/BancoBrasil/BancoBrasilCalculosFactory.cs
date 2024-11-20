using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoBrasil;

public class BancoBrasilCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto()
    {
        return new BancoBrasilDesconto();
    }

    public IJuros CriarJuros()
    {
        return new BancoBrasilJuros();
    }

    public IMulta CriarMulta()
    {
        return new BancoBrasilMulta();
    }
}