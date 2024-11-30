namespace DesignPatterns.Comportamentais.Interpreter;

public class Subtracao : Operacao
{
    public Subtracao(IExpressao esquerda, IExpressao direita) 
        : base(esquerda, direita) { }

    public override int Interpretar(Dictionary<object, object> contexto)
    {
        var subtracao = Esquerda.Interpretar(contexto) - Direita.Interpretar(contexto);
        return subtracao;
    }
}