namespace DesignPatterns.Comportamentais.Memento;

public class TextBoxMemento : IMemento
{
    private TextBox TextBox;
    private int X;
    private int Y;
    private string Text;
    private string FontFamily;
    private string FontWeight;
    private int FontSize;
    private string TextAlign;

    public TextBoxMemento(
        TextBox textBox,
        int x,
        int y,
        string text,
        string fontFamily,
        string fontWeight,
        int fontSize,
        string textAlign
    )
    {
        TextBox = textBox;
        X = x;
        Y = y;
        Text = text;
        FontFamily = fontFamily;
        FontWeight = fontWeight;
        FontSize = fontSize;
        TextAlign = textAlign;
    }

    public void Restaurar()
    {
        TextBox.SetPosition(X, Y);
        TextBox.Text = Text;
        TextBox.FontFamily = FontFamily;
        TextBox.FontWeight = FontWeight;
        TextBox.FontSize = FontSize;
        TextBox.TextAlign = TextAlign;
    }
}