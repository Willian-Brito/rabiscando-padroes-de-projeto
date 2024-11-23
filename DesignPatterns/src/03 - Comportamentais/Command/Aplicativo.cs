using DesignPatterns.Comportamentais.Command.Comandos;

namespace DesignPatterns.Comportamentais.Command;

public class Aplicativo
{
    private List<ICommand> Comandos;

    public Aplicativo()
    {
        Comandos = new List<ICommand>();
    }

    public ICommand GetComando(int id)
    {
        var comando = Comandos.ElementAt(id);
        return comando;
    }

    public void DuploClick(int id)
    {
        var comando = Comandos.ElementAt(id);
        comando.Desfazer();
    }

    public void AoPrecionarBotao(int id)
    {
        var comando = Comandos.ElementAt(id);
        comando.Executar();
    }

    public int SetComando(ICommand comando)
    {
        Comandos.Add(comando);
        return Comandos.IndexOf(comando);
    }
}