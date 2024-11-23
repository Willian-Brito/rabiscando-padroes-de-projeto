namespace DesignPatterns.Comportamentais.Memento;

public class Historico
{
    private List<IMemento> HistoricoList = new List<IMemento>();

    public void CriarSnapshot(IOriginador originador)
    {
        var memento = originador.Salvar();
        HistoricoList.Add(memento);
    }

    public void Desfazer()
    {
        if(HistoricoList.Count == 0)
            return;

        var memento = HistoricoList.Last();
        HistoricoList.RemoveAt(HistoricoList.Count - 1);
        memento.Restaurar();
    }

    public void Imprimir(IOriginador originador)
    {
        originador.Imprimir();
    }
}