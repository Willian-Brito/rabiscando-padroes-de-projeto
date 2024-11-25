namespace DesignPatterns.Criacionais.Singleton;

public interface IConexao
{
    List<object>? ExecuteQuery(string query);
}