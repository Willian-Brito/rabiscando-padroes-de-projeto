namespace DesignPatterns.Criacionais.Builder;

public class BuilderA3 : IBuilderGeradorPDF
{
    private GeradorPDF A3;

    public BuilderA3()
    {
        A3 = new GeradorPDF();
    }

    public GeradorPDF GetGeradorPDF()
    {
        return A3;
    }

    public void SetFooter()
    {
        A3.HasFooter = false;
        A3.FooterHeigh = 0;
    }

    public void SetHeader()
    {
        A3.HasHeader = false;
        A3.HeaderHeigh = 0;
    }

    public void SetMargin()
    {
        A3.MarginTop = 60;
        A3.MarginRight = 40;
        A3.MarginBottom = 60;
        A3.MarginLeft = 40;
    }

    public void SetPageConfiguration()
    {
        A3.PageOrientation = "portrait";
        A3.Unit = "mm";
        A3.PageSizeX = 297;
        A3.PageSizeY = 420;        
        A3.PageColor = "#ffffff";
        A3.Encode = "UTF-8";
    }
}