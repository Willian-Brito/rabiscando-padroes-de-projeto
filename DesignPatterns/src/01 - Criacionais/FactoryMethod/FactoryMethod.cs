using Caixa = DesignPatterns.Criacionais.FactoryMethod.BancoCaixa;
using Brasil = DesignPatterns.Criacionais.FactoryMethod.BancoBrasil;

namespace DesignPatterns.Criacionais.FactoryMethod;

public class FactoryMethod
{
    public static void Executar()
    {    
        #region Banco Caixa    
        Console.WriteLine("## BANCO CAIXA\n");
        
        var bancoCaixa = new Caixa.BancoCaixa();

        bancoCaixa.GerarBoleto(10, 100M);    
        bancoCaixa.GerarBoleto(30, 100M);    
        bancoCaixa.GerarBoleto(60, 100M);
        #endregion

        #region Banco do Brasil

        Console.WriteLine("## BANCO DO BRASIL\n");

        var bancoBrasil = new Brasil.BancoBrasil();
        
        bancoBrasil.GerarBoleto(10, 100M);
        bancoBrasil.GerarBoleto(30, 100M);        
        bancoBrasil.GerarBoleto(60, 100M);
        #endregion
    }
}