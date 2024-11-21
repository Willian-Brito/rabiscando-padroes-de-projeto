namespace DesignPatterns.Comportamentais.Iterator;

public class Matriz : IAgregado
{
    private object[,] Array; 
    public int QuantidadeLinhas {get; private set;}
    public int QuantidadeColunas {get; private set;}
    private int LinhaAtual = 0;
    private int ColunaAtual = 0;

    public Matriz(int quantidadeLinhas, int quantidadeColunas)
    {
        QuantidadeLinhas = quantidadeLinhas;
        QuantidadeColunas = quantidadeColunas;
        Array = new object[QuantidadeLinhas, QuantidadeColunas];
    }

    public IIterator CreateIterator()
    {
        return new MatrizIterator(this);
    }

    public bool AddItem(object item)
    {
        var ehUltimaLinha = LinhaAtual == (QuantidadeLinhas - 1);
        var ehUltimaColuna =  ColunaAtual == QuantidadeColunas;
        
        if( ehUltimaLinha && ehUltimaColuna)
            return false;

        if(ehUltimaColuna)
        {
            LinhaAtual++;
            ColunaAtual = 0;
        }

        Array[LinhaAtual, ColunaAtual] = item;
        ColunaAtual++;

        return true;
    }

    public object GetItem(int linha, int coluna)
    {
        return Array[linha, coluna];
    }
}