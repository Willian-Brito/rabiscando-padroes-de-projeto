namespace DesignPatterns.Criacionais.AbstractFactory.Abstract;

public interface ICalculosFactory
{
    IJuros CriarJuros();
    IDesconto CriarDesconto();
    IMulta CriarMulta();
}