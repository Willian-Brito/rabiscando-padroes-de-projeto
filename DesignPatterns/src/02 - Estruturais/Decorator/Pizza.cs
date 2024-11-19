namespace DesignPatterns.Estruturais.Decorator;

public abstract class Pizza
{
    protected string Descricao { get; set; } = "Descrição não definida";
    public decimal Preco { get; set; }

    public abstract string GetDescricao();
    public abstract decimal GetPreco();
}