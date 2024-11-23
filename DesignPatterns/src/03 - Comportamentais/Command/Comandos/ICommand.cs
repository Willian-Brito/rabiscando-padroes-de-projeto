namespace DesignPatterns.Comportamentais.Command.Comandos;

public interface ICommand
{
    void Executar();
    void Desfazer();
}
