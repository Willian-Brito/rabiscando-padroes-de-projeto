namespace DesignPatterns.Comportamentais.Memento;

public interface IOriginador
{
    IMemento Salvar();
    void Imprimir();
}