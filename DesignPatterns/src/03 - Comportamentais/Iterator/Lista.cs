namespace DesignPatterns.Comportamentais.Iterator;

public class Lista : IAgregado
{
    private List<object> Array; 
    private int Tamanho = 0;

    public Lista(int tamanho)
    {
        Tamanho = tamanho;
        Array = new List<object>();
    }

    public IIterator CreateIterator()
    {
        return new ListaIterator(this);
    }

    public bool AddItem(object item)
    {
        if(Array.Count() < Tamanho)
        {
            Array.Add(item);
            return true;
        }

        return false;
    }

    public object GetItem(int indice)
    {
        return Array.ElementAt(indice);
    }

    public int GetTamanho()
    {
        return Tamanho;
    }
}