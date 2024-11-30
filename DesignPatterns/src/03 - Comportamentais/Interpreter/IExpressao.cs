namespace DesignPatterns.Comportamentais.Interpreter;

public interface IExpressao
{
    int Interpretar(Dictionary<object, object> contexto);
}