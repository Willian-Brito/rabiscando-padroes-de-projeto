namespace DesignPatterns.Comportamentais.Interpreter;

public class Variavel : IExpressao
{
    private string _Variavel;

    public Variavel(string variavel)
    {
        _Variavel = variavel;
    }

    public int Interpretar(Dictionary<object, object> contexto)
    {
        var variavel = contexto[_Variavel];

        if(ValidarVariavel() && variavel != null)
            return Convert.ToInt32(variavel);

        throw new Exception("A variável precisa ser uma letra de a-z e estar definida no contexto!");
    }

    private bool ValidarVariavel()
    {
        var variaveis = new string[] { 
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        return variaveis.Contains(_Variavel);
    }
}