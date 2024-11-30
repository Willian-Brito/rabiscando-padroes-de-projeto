namespace DesignPatterns.Comportamentais.Interpreter;

public abstract class Operacao : IExpressao
{
    protected IExpressao Esquerda;
    protected IExpressao Direita;

    public Operacao(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public abstract int Interpretar(Dictionary<object, object> contexto);
}