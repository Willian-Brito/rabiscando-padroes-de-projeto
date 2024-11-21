namespace DesignPatterns.Comportamentais.Iterator;

public class MatrizIterator : IIterator
{
    private Matriz Matriz;
    private int IndiceLinha = 0;
    private int IndiceColuna = 0;
    private int QuantidadeLinha = 0;
    private int? QuantidadeColuna = 0;

    public MatrizIterator(Matriz matriz)
    {
        Matriz = matriz;
        QuantidadeLinha = matriz.QuantidadeLinhas;
        QuantidadeColuna = matriz.QuantidadeColunas;
    }

    public bool HasNext()
    {
        if(IndiceLinha >= QuantidadeLinha)
            return false;

        return true;
    }

    public object Next()
    {
        var item = Matriz.GetItem(IndiceLinha, IndiceColuna);
        IncrementarIndice();

        return item;
    }

    private void IncrementarIndice()
    {
        var ehUltimaColuna = IndiceColuna == (QuantidadeColuna - 1);

        if(ehUltimaColuna)
        {
            IndiceLinha++;
            IndiceColuna = 0;
        }
        else
        {
            IndiceColuna++;
        }
    }
}