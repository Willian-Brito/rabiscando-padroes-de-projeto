namespace DesignPatterns.Comportamentais.Iterator;

public class ListaIterator : IIterator
{
    private Lista Lista;
    private int Indice = 0;

    public ListaIterator(Lista lista)
    {
        Lista = lista;
    }

    public bool HasNext()
    {
        if(Indice >= Lista.GetTamanho())
            return false;

        return true;
    }

    public object Next()
    {
        var item = Lista.GetItem(Indice);
        Indice++;
        return item;
    }
}