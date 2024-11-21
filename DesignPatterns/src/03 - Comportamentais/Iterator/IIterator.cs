namespace DesignPatterns.Comportamentais.Iterator;

public interface IIterator
{
    bool HasNext();
    object Next();
}