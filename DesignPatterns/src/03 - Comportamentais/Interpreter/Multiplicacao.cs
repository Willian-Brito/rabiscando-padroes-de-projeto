namespace DesignPatterns.Comportamentais.Interpreter;

public class Multiplicacao : Operacao
{
    public Multiplicacao(IExpressao esquerda, IExpressao direita) 
        : base(esquerda, direita) { }

    public override int Interpretar(Dictionary<object, object> contexto)
    {
        var multiplicacao = Esquerda.Interpretar(contexto) * Direita.Interpretar(contexto);
        return multiplicacao;
    }
}