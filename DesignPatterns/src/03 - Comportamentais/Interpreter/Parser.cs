namespace DesignPatterns.Comportamentais.Interpreter;

public class Parser
{
    private Stack<IExpressao> Pilha;
    private string Expressao;

    public Parser(string expressao)
    {
        Pilha = new Stack<IExpressao>();
        Expressao = expressao.Trim();
    }

    private bool IsOperacao(string token)
    {
        var operacoes = new string[] {"+", "-", "*", "/"};
        return operacoes.Contains(token);
    }
    
    private Numero ParseNumero(string token)
    {
        var pilha = new Stack<object>();
        Numero direita = null;

        for(var i = 0; i < token.Length; i++)
        {
            var parteToken = token.Substring(i, 1);
            var ehUltimo = i == token.Length - 1;

            if(ehUltimo)
            {
                pilha.Push(new Digito(parteToken));

                while(pilha.Count > 0)
                {
                    var topo = pilha.Peek();

                    if(topo is Digito)
                    {
                        if(direita is null)
                        {
                            direita = new Numero(topo as Digito);
                            pilha.Pop();
                        }
                        else
                        {
                            direita = new Numero(topo as Digito, direita as Numero);
                            pilha.Pop();
                        }
                    }
                }
            }
            else
            {
                pilha.Push(new Digito(parteToken));
            }
        }

        return direita;
    }

    public IExpressao Parse()
    {
        var expressao = Expressao.Split(" ");

        foreach(var token in expressao)
        {
            if(IsOperacao(token))
            {
                var operandoDireita = Pilha.Peek();
                Pilha.Pop();

                var operandoEsquerda = Pilha.Peek();
                Pilha.Pop();

                switch (token)
                {
                    case "+":
                        Pilha.Push(new Adicao(operandoEsquerda, operandoDireita));
                        break;
                    case "-":
                        Pilha.Push(new Subtracao(operandoEsquerda, operandoDireita));
                        break;
                    case "*":
                        Pilha.Push(new Multiplicacao(operandoEsquerda, operandoDireita));
                        break;
                    case "/":
                        Pilha.Push(new Divisao(operandoEsquerda, operandoDireita));
                        break;
                }
            }
            else if(int.TryParse(token, out _))
            {
                Pilha.Push(ParseNumero(token));
            }
            else
            {
                Pilha.Push(new Variavel(token));
            }
        }

        return Pilha.Peek();
    }

}