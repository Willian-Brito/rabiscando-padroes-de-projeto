namespace DesignPatterns.Comportamentais.Interpreter;

public class Digito : IExpressao
{
    private string _Digito;

    public Digito(string digito)
    {
        _Digito = digito;
    }

    public int Interpretar(Dictionary<object, object> contexto)
    {
        if(ValidarDigito())
            return Convert.ToInt32(_Digito);

        throw new Exception("Todo dígito deve ser um inteiro!");
    }

    private bool ValidarDigito()
    {
        var digitos = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        return digitos.Contains(_Digito);
    }
}