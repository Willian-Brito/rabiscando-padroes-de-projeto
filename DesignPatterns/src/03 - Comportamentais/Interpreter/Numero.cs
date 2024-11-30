namespace DesignPatterns.Comportamentais.Interpreter;

public class Numero : IExpressao
{
    private Digito Esquerda;
    private Numero? Direita;

    public Numero(Digito esquerda, Numero? direita = null)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public int Interpretar(Dictionary<object, object> contexto)
    {
        if(Direita is null)
            return Esquerda.Interpretar(contexto);

        return Convert.ToInt32(
            $"{Esquerda.Interpretar(contexto)}{Direita.Interpretar(contexto)}"
        );
    }
}