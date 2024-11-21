namespace DesignPatterns.Comportamentais.Iterator;

public class Iterator
{
    public static void Executar()
    {
        #region Sem Padrão Iterator

        // var lista = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        // var matriz = new int[3, 3]
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // ## Iterações

        // ## Lista
        // Console.WriteLine("# Elementos da Lista:");
        // for(int i = 0; i < lista.Length; i++)
        // {
        //     Console.Write($"{lista[i]} ");
        // }

        // // ## Matriz
        // Console.WriteLine("\n\n# Elementos da Matriz:");
        // var qtdLinhas = 3;
        // var qtdColunas = 3;

        // for(int linha = 0; linha < qtdLinhas; linha++)
        // {
        //     for(int coluna = 0; coluna < qtdColunas; coluna++)
        //     {
        //         Console.Write($"{matriz[linha, coluna]} ");
        //     }
        // }

        // var lista = new int[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        // var matriz = new int[3, 3]
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };
        #endregion

        #region Com Padrão Iterator

        var lista = new Lista(9);
        lista.AddItem(1);
        lista.AddItem(2);
        lista.AddItem(3);
        lista.AddItem(4);
        lista.AddItem(5);
        lista.AddItem(6);
        lista.AddItem(7);
        lista.AddItem(8);
        lista.AddItem(9);
        lista.AddItem(10);

        var matriz = new Matriz(3, 3);
        matriz.AddItem(1);
        matriz.AddItem(2);
        matriz.AddItem(3);
        matriz.AddItem(4);
        matriz.AddItem(5);
        matriz.AddItem(6);
        matriz.AddItem(7);
        matriz.AddItem(8);
        matriz.AddItem(9);
        matriz.AddItem(10);

        Console.WriteLine("## Lista:");
        Imprimir(lista);
        
        Console.WriteLine("\n\n## Matriz:");
        Imprimir(matriz);

        #endregion
    }

    public static void Imprimir(IAgregado agregado)
    {
        var iterator = agregado.CreateIterator();
        while (iterator.HasNext())
            Console.Write($"{iterator.Next()} ");
    }
}