namespace DesignPatterns.Comportamentais.Memento;

public class Memento
{
    public static void Executar()
    {
        var textBox = new TextBox(20, 100);
        var historico = new Historico();

        textBox.Text = "Teste de caixa de texto";
        textBox.FontWeight = "bold";
        textBox.FontFamily = "Cursive";
        textBox.FontSize = 25;      

        historico.CriarSnapshot(textBox);

        textBox.Text = "Teste de caixa de texto editado";
        textBox.FontWeight = "normal";
        textBox.FontFamily = "Monospace";
        textBox.FontSize = 15;
        textBox.SetPosition(40, 110);

        historico.CriarSnapshot(textBox);        

        textBox.Text = "Teste de caixa de texto editado";
        textBox.FontWeight = "normal";
        textBox.FontFamily = "Fantasy";
        textBox.FontSize = 12;
        textBox.SetPosition(60, 120);

        textBox.Imprimir();
        historico.Desfazer();
        textBox.Imprimir();
        historico.Desfazer();
        textBox.Imprimir();
    }
}