
namespace DesignPatterns.Criacionais.Singleton;

public class MySql : IConexao
{
    private static MySql Instance;
    public string Host { get; set; }
    public string User { get; set; }
    public string Pass { get; set; }

    private MySql()
    {
        Host = "String de conexão";
        User = "pedrosilva";
        Pass = "pedro123";
    }

    public List<object>? ExecuteQuery(string query)
    {
        Console.WriteLine($"A query \n {query} \n foi executada com sucesso");
        return null;
    }

    public string ToString()
    {
        var json = $"{{ \"Host\": \"{Host}\", \"User\": \"{User}\", \"Pass\": \"{Pass}\" }}";
        return json;
    }

    public static MySql GetInstace()
    {
        if(Instance == null)
        {
            Instance = new MySql();
            return Instance;
        }

        return Instance;
    }
}
