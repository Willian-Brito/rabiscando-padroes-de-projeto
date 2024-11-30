namespace DesignPatterns.Comportamentais.Interpreter;

public class Adicao : Operacao
{
    public Adicao(IExpressao esquerda, IExpressao direita) 
        : base(esquerda, direita) { }

    public override int Interpretar(Dictionary<object, object> contexto)
    {
        var adicao = Esquerda.Interpretar(contexto) + Direita.Interpretar(contexto);
        return adicao;
    }
}