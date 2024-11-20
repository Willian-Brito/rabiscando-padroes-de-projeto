namespace DesignPatterns.Criacionais.Builder;

public class BuilderA4 : IBuilderGeradorPDF
{
    private GeradorPDF A4;

    public BuilderA4()
    {
        A4 = new GeradorPDF();
    }

    public GeradorPDF GetGeradorPDF()
    {
        return A4;
    }

    public void SetFooter()
    {
        A4.HasFooter = true;
        A4.FooterHeigh = 15;
    }

    public void SetHeader()
    {
        A4.HasHeader = true;
        A4.HeaderHeigh = 15;
    }

    public void SetMargin()
    {
        A4.MarginTop = 30;
        A4.MarginRight = 20;
        A4.MarginBottom = 30;
        A4.MarginLeft = 20;
    }

    public void SetPageConfiguration()
    {
        A4.PageOrientation = "portrait";
        A4.Unit = "mm";
        A4.PageSizeX = 210;
        A4.PageSizeY = 297;       
        A4.PageColor = "#ffffff";
        A4.Encode = "UTF-8";
    }
}