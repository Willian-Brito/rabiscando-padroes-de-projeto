using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory.BancoCaixa;

public class BancoCaixaJuros : IJuros
{
    public decimal GetJuros()
    {
        return 0.02M;
    }
}