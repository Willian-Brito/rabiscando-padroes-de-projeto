using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoCaixa;

public class BancoCaixaCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto()
    {
        return new BancoCaixaDesconto();
    }

    public IJuros CriarJuros()
    {
        return new BancoCaixaJuros();
    }

    public IMulta CriarMulta()
    {
        return new BancoCaixaMulta();
    }
}