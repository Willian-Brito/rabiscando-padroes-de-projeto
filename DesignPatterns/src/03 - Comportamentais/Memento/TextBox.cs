namespace DesignPatterns.Comportamentais.Memento;

public class TextBox : IOriginador
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Text { get; set; }
    public string FontFamily { get; set; }
    public string FontWeight { get; set; }
    public int FontSize { get; set; }
    public string TextAlign { get; set; }

    public TextBox(int x, int y)
    {
        X = x;
        Y = y;
        Text = "";
        FontFamily = "Arial";
        FontSize = 14;
        TextAlign = "left";
        FontWeight = "normal";
    }

    public void Imprimir()
    {
        Console.WriteLine("----------------------------");
        
        Console.WriteLine($"X: {X}");
        Console.WriteLine($"Y: {Y}");
        Console.WriteLine($"Text: {Text}");
        Console.WriteLine($"Font Weight: {FontWeight}");
        Console.WriteLine($"Font Family: {FontFamily}");
        Console.WriteLine($"Font Size: {FontSize}");
        Console.WriteLine($"Text Align: {TextAlign}");
    }

    public void SetPosition(int x, int y)
    {
        X = X;
        Y = y;
    }

    public IMemento Salvar()
    {
        var memento = new TextBoxMemento(
            this,
            X ,
            Y,
            Text,
            FontFamily,
            FontWeight,
            FontSize,
            TextAlign
        );

        return memento;
    }
}