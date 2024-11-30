namespace DesignPatterns.Comportamentais.Interpreter;

public class Divisao : Operacao
{
    public Divisao(IExpressao esquerda, IExpressao direita) 
        : base(esquerda, direita) { }

    public override int Interpretar(Dictionary<object, object> contexto)
    {
        var divicao = Convert.ToInt32(
            Esquerda.Interpretar(contexto) / Direita.Interpretar(contexto)
        );

        return divicao;
    }
}