
namespace DesignPatterns.Criacionais.Singleton;

public class Singleton
{
    public static void Executar()
    {
        var bancoMySql1 = MySql.GetInstace();

        var query = @"CREATE TABLE usuario (
                        id INT(11) AUTO_INCREMENT PRIMARY KEY,
                        nome VARCHAR(100) NOT NULL,
                        email VARCHAR(60),
                        senha VARCHAR(100)
                    )";

        bancoMySql1.ExecuteQuery(query);

        Console.WriteLine("\n==== bancoMySql1 ====");
        Console.WriteLine(bancoMySql1.ToString());

        var bancoMySql2 = MySql.GetInstace();
        
        Console.WriteLine("\n==== bancoMySql2 ====");
        Console.WriteLine(bancoMySql2.ToString());

        Console.WriteLine("\n==== MUDANÇA DE USUÁRIO EM bancoMySql1 ====");
        bancoMySql1.User = "mariaDaSilva";

        Console.WriteLine("\n==== bancoMySql1 ====");
        Console.WriteLine(bancoMySql1.ToString());

        Console.WriteLine("\n==== bancoMySql2 ====");
        Console.WriteLine(bancoMySql2.ToString());
    }
}
