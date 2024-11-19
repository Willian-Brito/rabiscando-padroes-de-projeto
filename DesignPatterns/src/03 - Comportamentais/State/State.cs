
namespace DesignPatterns.Comportamentais.State;

public class State
{
    public static void Executar()
    {
        var pedido = new Pedido();

        #region Transições

        #region Aguardando Pagamento

        // Aguardando Pagamento -> Enviado
        // pedido.Despachar();

        // Aguardando Pagamento -> Pago
        // pedido.Pagar();

        #endregion

        #region Cancelado
        
        // pedido.Cancelar();

        // // Cancelado -> Cancelado
        // pedido.Cancelar();

        // // Cancelado -> Pago
        // pedido.Pagar();

        // // Cancelado -> Enviado
        // pedido.Despachar();
        
        #endregion

        #region Pago
        
        // pedido.Pagar();

        // // Pago -> Pago
        // pedido.Pagar();

        // // Pago -> Cancelado
        // pedido.Cancelar();

        #endregion

        #region Enviado
        
        // pedido.Pagar();
        // pedido.Despachar();

        // // Enviado -> Pago
        // pedido.Pagar();

        // // Enviado -> Enviado
        // pedido.Despachar();

        // // Enviado -> Cancelado
        // pedido.Cancelar();

        #endregion
        
        #region Fluxo sem erros
        
        // // Aguarddando Pagamento -> Pago
        // pedido.Pagar();

        // // Pago -> Enviado
        // pedido.Despachar();

        #endregion

        #endregion
    }
}