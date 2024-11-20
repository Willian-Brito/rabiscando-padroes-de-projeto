namespace DesignPatterns.Estruturais.Facade.Vendas;

public class Pedido
{
    public Consumidor Consumidor {get; set;}
    public List<Produto> Produtos {get; set;} = new List<Produto>();
    public decimal Valor {get; set;}

    public Pedido(Consumidor consumidor)
    {
        Consumidor = consumidor;
    }

    public void AddProduto(Produto produto)
    {
        Produtos.Add(produto);
        Valor = Produtos.Sum(p => p.Valor);
    }
}