using DesignPatterns.Estruturais.Facade.Vendas;

namespace DesignPatterns.Estruturais.Facade;

public class Facade
{
    public static void Executar()
    {
        //Criação do consumidor.
        var consumidor = new Consumidor("Willian Brito", "12345678910", "wbrito@facade.com");

        //Criação de produtos.
        var produto1 = new Produto("Blusa Rosa", "Blusa feminina rosa", 80.99M);
        var produto2 = new Produto("Camiseta Preta", "Camiseta masculina preta", 49.9M);
        var produto3 = new Produto("Calça Jeans", "Calça Jeans Masculina", 119.90M);
        

        // ==== Até aqui apenas criamos os objetos básicos que uma venda precisa. ====
        // ==== Agora vamos ao processo de venda propriamente dito. ====

        // # Sem Facade
        // var pedido = new Pedido(consumidor);
        // pedido.AddProduto(produto1);
        // pedido.AddProduto(produto2);
        // pedido.AddProduto(produto3);

        // var pagamento = new PagamentoBoleto(pedido);
        // var email = new EmailPedido(pedido);

        // if(pagamento.Pagar())
        //     email.Enviar("Pagamento realizado com sucesso via boleto!");
        // else 
        //     email.Enviar("Falha no pagamento via crédito");


        // # Com Facade
        var vendaFacade = new VendaFacade(consumidor);
        
        vendaFacade.AddProduto(produto1);
        vendaFacade.AddProduto(produto2);
        vendaFacade.AddProduto(produto3);

        vendaFacade.PagarComBoleto();
    }
}