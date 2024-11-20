namespace DesignPatterns.Estruturais.Facade;

public class Produto
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Valor { get; private set; }

    public Produto(string nome, string descricao, decimal valor)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
    }
}