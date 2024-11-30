namespace DesignPatterns.Comportamentais.Interpreter;

public class Interpreter
{
    public static void Executar()
    {   
        // abstract syntax tree
        // var ast = new Subtracao(
        //     new Subtracao(
        //         new Adicao(
        //             new Numero(new Digito("5")),
        //             new Numero(new Digito("9"))
        //         ),
        //         new Variavel("x")
        //     ),
        //     new Divisao(
        //         new Subtracao(
        //             new Multiplicacao(
        //                 new Numero(new Digito("2"), new Numero(new Digito("0"))),
        //                 new Numero(new Digito("2"))
        //             ),
        //             new Numero(new Digito("1"), new Numero(new Digito("0")))
        //         ),
        //         new Variavel("y")
        //     )
        // );

        // var contexto = new Dictionary<object, object>{ { "x", 2 }, { "y", 3 } };

        // Console.WriteLine($"{ast.Interpretar(contexto)}");

        var parser = new Parser("9 5 + x - 20 2 * 10 - y / -");
        var ast = parser.Parse();
        var contexto = new Dictionary<object, object>{ { "x", 2 }, { "y", 3 } };

        Console.WriteLine($"{ast.Interpretar(contexto)}");
    }
}