using DesignPatterns.Criacionais.AbstractFactory.BancoCaixa;
using DesignPatterns.Criacionais.AbstractFactory.BancoBrasil;
using DesignPatterns.Criacionais.AbstractFactory.Abstract;

namespace DesignPatterns.Criacionais.AbstractFactory;

public class AbstractFactory
{
    public static void Executar()
    {    
        ICalculosFactory abstractFactory;
        var banco = new Banco();


        Console.WriteLine("## BANCO CAIXA\n");   

        abstractFactory = new BancoCaixaCalculosFactory();
        banco.GerarBoleto(100M, abstractFactory);


        Console.WriteLine("## BANCO DO BRASIL\n");

        abstractFactory = new BancoBrasilCalculosFactory();
        banco.GerarBoleto(100M, abstractFactory);

    }
}